package com.example.firebaseproject;

import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

public class DetailsActivity extends AppCompatActivity {
    TextView txtname, txtprijmeni, txtprace, txtbydliste;
    DatabaseReference myRef;
    Intent intent;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_details);
        txtname = (TextView)findViewById(R.id.JmenoText);
        txtprijmeni = (TextView)findViewById(R.id.PrijmeniText);
        txtprace = (TextView)findViewById(R.id.PraceText);
        txtbydliste = (TextView)findViewById(R.id.DomovText);
        intent = getIntent();

        myRef = FirebaseDatabase.getInstance().getReference().child("Osoba").child(intent.getStringExtra("id"));

        myRef.addValueEventListener(new ValueEventListener(){
            @Override
            public void onDataChange(@NonNull DataSnapshot dataSnapshot){
                if(dataSnapshot.child("jmeno").getValue() != null && dataSnapshot.child("prijmeni").getValue() != null && dataSnapshot.child("prace").getValue() != null && dataSnapshot.child("bydliste").getValue() != null) {
                    txtname.setText(dataSnapshot.child("jmeno").getValue().toString());
                    txtprijmeni.setText(dataSnapshot.child("prijmeni").getValue().toString());
                    txtprace.setText(dataSnapshot.child("prace").getValue().toString());
                    txtbydliste.setText(dataSnapshot.child("bydliste").getValue().toString());
                }
            }

            @Override
            public void onCancelled(@NonNull DatabaseError databaseError){}
        });
    }

    public void Smazat(View view)
    {
        DialogInterface.OnClickListener dialogClickListener = new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                switch (which){
                    case DialogInterface.BUTTON_POSITIVE:
                        myRef.removeValue();
                        finish();
                        break;

                    case DialogInterface.BUTTON_NEGATIVE:
                        break;
                }
            }
        };

        AlertDialog.Builder builder = new AlertDialog.Builder(this);
        builder.setMessage("Chcete smazat záznam?").setPositiveButton("Ano", dialogClickListener).setNegativeButton("Ne", dialogClickListener).show();
    }

    public void Edit(View view) {
        Intent it = new Intent(DetailsActivity.this,EditActivity.class);
        it.putExtra("id",intent.getStringExtra("id"));
        it.putExtra("jmeno",txtname.getText().toString());
        it.putExtra("prijmeni",txtprijmeni.getText().toString());
        it.putExtra("prace",txtprace.getText().toString());
        it.putExtra("bydliste",txtbydliste.getText().toString());
        startActivity(it);
    }
}
