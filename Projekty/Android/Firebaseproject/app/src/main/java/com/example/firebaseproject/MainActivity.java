package com.example.firebaseproject;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;

import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {
DatabaseReference myRef;
List<String> datalist = new ArrayList<String>();
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        ListView ls = findViewById(R.id.list);
        Button btn = findViewById(R.id.ZapsatButton);
        myRef = FirebaseDatabase.getInstance().getReference("Osoba");

        ArrayAdapter<String> aa = new ArrayAdapter<String>(this, android.R.layout.simple_list_item_1, datalist);
        ls.setAdapter(aa);

        myRef.addValueEventListener(new ValueEventListener(){
            @Override
            public void onDataChange(@NonNull DataSnapshot dataSnapshot){
                int i = 1;
                //datalist.clear();
                for(DataSnapshot childSnapShot : dataSnapshot.getChildren())
                    {
                        datalist.add("Osoba"+i);
                        i++;
                    }
                aa.notifyDataSetChanged();
            }

            @Override
            public void onCancelled(@NonNull DatabaseError databaseError){}
        });

        ls.setOnItemClickListener(new AdapterView.OnItemClickListener(){
            @Override
            public void onItemClick(AdapterView<?>adapter,View v, int position,long id){
                String item = (String)adapter.getItemAtPosition(position);

                Intent intent = new Intent(MainActivity.this,DetailsActivity.class);
                intent.putExtra("id",item);
                startActivity(intent);
            }
        });
        btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent zapis = new Intent(MainActivity.this,WriteActivity.class);
                startActivity(zapis);
            }
        });
    }
}