package com.example.firebaseproject;

import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;

public class EditActivity extends AppCompatActivity {
    EditText txtid, txtname, txtprijmeni, txtprace, txtbydliste;
    Button btnsend;
    Intent intent;
    DatabaseReference myRef;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_edit);
        intent = getIntent();
        txtid = (EditText) findViewById(R.id.IdText);
        txtname = (EditText) findViewById(R.id.TextName);
        txtprijmeni = (EditText) findViewById(R.id.TextPrijmeni);
        txtprace = (EditText) findViewById(R.id.TextPrace);
        txtbydliste = (EditText) findViewById(R.id.TextBydliste);
        btnsend = (Button) findViewById(R.id.SendButton);

        myRef = FirebaseDatabase.getInstance().getReference().child("Osoba");
        txtid.setText(intent.getStringExtra("id"));
        txtname.setText(intent.getStringExtra("jmeno"));
        txtprijmeni.setText(intent.getStringExtra("prijmeni"));
        txtprace.setText(intent.getStringExtra("prace"));
        txtbydliste.setText(intent.getStringExtra("bydliste"));
    }

    public void Edit(View view)
    {
        Osoba osb = new Osoba();
        DialogInterface.OnClickListener dialogClickListener = new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                switch (which){
                    case DialogInterface.BUTTON_POSITIVE:
                        osb.setJmeno(txtname.getText().toString());
                        osb.setPrijmeni(txtprijmeni.getText().toString());
                        osb.setPrace(txtprace.getText().toString());
                        osb.setBydliste(txtbydliste.getText().toString());
                        myRef.child(txtid.getText().toString()).setValue(osb);
                        finish();
                        break;

                    case DialogInterface.BUTTON_NEGATIVE:
                        break;
                }
            }
        };

        AlertDialog.Builder builder = new AlertDialog.Builder(this);
        builder.setMessage("Opravdu chcete upravit záznam?").setPositiveButton("Ano", dialogClickListener).setNegativeButton("Ne", dialogClickListener).show();
    }
}
