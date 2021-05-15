package com.example.kalkulaka;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.renderscript.Script;
import android.view.View;
import android.widget.TextView;
import android.widget.Toast;

import org.mozilla.javascript.regexp.SubString;

import javax.script.ScriptEngine;
import javax.script.ScriptEngineManager;
import javax.script.ScriptException;

public class MainActivity extends AppCompatActivity {

    TextView hodnotaTV;
    TextView vysledekTV;

    String Hodnota = "";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        InitTV();
    }

    public void InitTV()
    {
        hodnotaTV = (TextView) findViewById(R.id.HodnotaTV);
        vysledekTV = (TextView) findViewById(R.id.VysledekTV);
    }

    // procedura, která nastaví zapsanou hodnotu do textview
    public void SetHodnota(String x)
    {
        Hodnota = Hodnota + x; //Přidá ke string hodnotě parametr
        hodnotaTV.setText(Hodnota); //Nastaví text k textView
    }

    public void Remove(View v)
    {
        Hodnota = Hodnota.substring(0, Hodnota.length()-1);
        SetHodnota(Hodnota);
    }

    public void RemoveAll(View v)
    {
        Hodnota = "";
        SetHodnota(Hodnota);
    }

    public void EqualsOnClick(View view)
    {
        Double vysledek = null;
        ScriptEngine engine = new ScriptEngineManager().getEngineByName("rhino");//Inicializace ScriptEnginu, který nám pomůže s výpočtama
        try {
            vysledek = (double) engine.eval(Hodnota); //Zavolání funkce eval, která rozloží Strin a spočítá příklad
        } catch (ScriptException e) {
            Toast.makeText(this, "Nesprávný vstup", Toast.LENGTH_SHORT).show();
        }

        if(vysledek != null)
        {
            vysledekTV.setText(vysledek.toString());
        }
    }

    public void PlusOnClick(View view)
    {
        SetHodnota("+");
    }

    public void MinusOnClick(View view)
    {
        SetHodnota("-");
    }

    public void MultiplyOnClick(View view)
    {
        SetHodnota("*");
    }

    public void DivideOnClick(View view)
    {
        SetHodnota("/");
    }

    public void NineOnClick(View view)
    {
        SetHodnota("9");
    }

    public void EightOnClick(View view)
    {
        SetHodnota("8");
    }

    public void SevenOnClick(View view)
    {
        SetHodnota("7");
    }

    public void SixOnClick(View view)
    {
        SetHodnota("6");
    }

    public void FiveOnClick(View view)
    {
        SetHodnota("5");
    }

    public void FourOnClick(View view)
    {
        SetHodnota("4");
    }

    public void ThreeOnClick(View view)
    {
        SetHodnota("3");
    }

    public void TwoOnClick(View view)
    {
        SetHodnota("2");
    }
    public void OneOnClick(View view)
    {
        SetHodnota("1");
    }

    public void ZeroOnClick(View view)
    {
        SetHodnota("0");
    }
}
