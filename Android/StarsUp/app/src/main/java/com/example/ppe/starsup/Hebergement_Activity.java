package com.example.ppe.starsup;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import java.io.Serializable;


public class Hebergement_Activity extends Activity {

    private HEBERGEMENT hebergement; //Objet Hebergement

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_hebergement);

        Button btn_rediger = (Button) findViewById(R.id.btn_rediger);
        btn_rediger.setOnClickListener(click); // btnclick à garder

        //Réception les données passées par le Intent
        Bundle b = getIntent().getExtras();
        String nom = b.getString("nom");
        hebergement = (HEBERGEMENT) getIntent().getSerializableExtra("hebergement");
        //Toast.makeText(getApplicationContext(), "Chargement effectuée ! Hébergement : " + hebergement.getNOM_HEBERGEMENT(), Toast.LENGTH_LONG).show();

        //Chargement des infos dans la page
        ((TextView) findViewById(R.id.txt_nom)).setText(nom);
        /*((TextView) findViewById(R.id.txt_nom)).setText(hebergement.getNOM_HEBERGEMENT());
        ((TextView) findViewById(R.id.txt_web)).setText(hebergement.getWEBSITE_HEBERGEMENT());
        ((TextView) findViewById(R.id.txt_horaires)).setText(hebergement.getHORAIRES_HEBERGEMENT());
        ((TextView) findViewById(R.id.txt_adresse)).setText(hebergement.getVILLE_HEBERGEMENT()+"\n"+hebergement.getADRESSE_HEBERGEMENT());*/
        //((EditText) findViewById(R.id.ratingBar)).setText("");
    }


    private View.OnClickListener click = new View.OnClickListener() {
        public void onClick(View v) {
            switch (v.getId()) {
                case R.id.btn_rediger : //gestion du click du radiobouton Cours collectif
                    Intent i = new Intent(getApplicationContext(), Visite_Activity.class);
                    //i.putExtra("info1", "Démarrage de l'activité");
                    i.putExtra("hebergement", (Serializable)hebergement);
                    startActivity(i);
                    break;
            }
        }

    };

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_hebergement, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }
}
