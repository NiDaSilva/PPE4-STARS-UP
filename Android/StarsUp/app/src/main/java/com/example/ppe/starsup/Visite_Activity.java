package com.example.ppe.starsup;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.RatingBar;
import android.widget.Toast;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;


public class Visite_Activity extends Activity {

    private HEBERGEMENT hebergement;
    private Modele BaseStartsUp;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_visite);

        Button btnEnvoyer = (Button) findViewById(R.id.btn_envoyer);
        btnEnvoyer.setOnClickListener(click);

        Bundle b = getIntent().getExtras();
        hebergement = (HEBERGEMENT) getIntent().getSerializableExtra("hebergement");

        BaseStartsUp = new Modele(); //creation de la nouvelle BDO
    }
    private View.OnClickListener click = new View.OnClickListener() {

        public void onClick(View v) {
            switch (v.getId()) {
                case R.id.btn_envoyer: /*clic sur btn Envoyer*/
                    Toast.makeText(getApplicationContext(), "Enregistrement du compte rendu en cours", Toast.LENGTH_SHORT).show();
                    try {
                        String commentaire = ((EditText)findViewById(R.id.txt_commentaire)).getText().toString();
                        Integer nbrEtoile = (int)((RatingBar)findViewById(R.id.bar_note)).getRating();

                        Integer id_hebergement = 0; //hebergement.getID_HEBERGEMENT();
                        Integer id_inspecteur = 0;
                        Date date_visite = null;

                        VISITE visite = new VISITE(id_hebergement, id_inspecteur, nbrEtoile, commentaire, date_visite); //Création du compte rendue

                        //BaseStartsUp.saveVisite(visite);    //Sauvegarde de la visite dans la base de données

                        //Ajoute de la visite a l'hebergement ?

                        Toast.makeText(getApplicationContext(), "Le compte rendu à bien été enregistrer !", Toast.LENGTH_SHORT).show();
                        Intent i = new Intent(getApplicationContext(), Planning_Activity.class);
                        startActivity(i);

                    }
                    catch (Exception e) {
                        e.printStackTrace();
                    }
                    break;
            }
        }
    };


    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_visite, menu);
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
