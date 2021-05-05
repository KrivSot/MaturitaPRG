package com.example.firebaseproject;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

public class WriteActivity extends AppCompatActivity {
    EditText txtname, txtprijmeni, txtprace, txtbydliste;
    Button btnsend;
    long maxid;
    long id;
    DatabaseReference myRef;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_write);
        txtname = (EditText) findViewById(R.id.TextName);
        txtprijmeni = (EditText) findViewById(R.id.TextPrijmeni);
        txtprace = (EditText) findViewById(R.id.TextPrace);
        txtbydliste = (EditText) findViewById(R.id.TextBydliste);
        btnsend = (Button) findViewById(R.id.SendButton);
        Osoba osb = new Osoba();
        myRef = FirebaseDatabase.getInstance().getReference().child("Osoba");

        myRef.addValueEventListener(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot dataSnapshot) {
                if (dataSnapshot.exists()) {
                    maxid = (dataSnapshot.getChildrenCount()); //získá počet záznamů v databázi
                }
            }

            @Override
            public void onCancelled(@NonNull DatabaseError databaseError) {
            }
        });

        btnsend.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                osb.setJmeno(txtname.getText().toString());
                osb.setPrijmeni(txtprijmeni.getText().toString());
                osb.setPrace(txtprace.getText().toString());
                osb.setBydliste(txtbydliste.getText().toString());
                id = maxid + 1; // id se musí zvýšit o jednu jinak dostaneme poslední id
                myRef.child("Osoba" + id).setValue(osb);
                finish();
            }
        });
    }
}
