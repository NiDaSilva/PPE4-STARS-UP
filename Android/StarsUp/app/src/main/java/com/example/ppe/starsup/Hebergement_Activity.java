package com.example.ppe.starsup;

import android.app.Activity;
import android.app.ProgressDialog;
import android.content.Intent;
import android.os.AsyncTask;
import android.os.Bundle;
import android.util.Log;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.RatingBar;
import android.widget.TextView;
import android.widget.Toast;

import org.apache.http.NameValuePair;
import org.apache.http.message.BasicNameValuePair;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.List;


public class Hebergement_Activity extends Activity {

    // Progress Dialog
    private ProgressDialog pDialog;

    // Creating JSON Parser object
    JSONParser jParser = new JSONParser();

    // products JSONArray
    JSONArray Update = null;

    // url to get all products list
    private static String update = "http://192.168.215.10/Android/set_visite.php";

    String id_v;
    String id_i;
    String note;
    String commentaire;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_hebergement);

        Button btn_envoyer = (Button) findViewById(R.id.btn_envoyer);
        btn_envoyer.setOnClickListener(click); // btnclick à garder

        //Réception les données passées par le Intent
        Bundle b = getIntent().getExtras();
        id_v = b.getString("id_v");
        id_i = b.getString("id_i");
        String nom = b.getString("nom");
        String horaires = b.getString("horaires");
        String adresse = b.getString("adresse");
        Float nbr_etoiles = 0.F;
        try {
            nbr_etoiles = Float.valueOf(b.getString("nbr_etoiles"));
        }
        catch(NumberFormatException ex) {
            nbr_etoiles = 0.F; // default ??
        }
        String commentaire = b.getString("commentaire");

        //Chargement des infos dans la page
        ((TextView) findViewById(R.id.txt_nom)).setText(nom);
        ((TextView) findViewById(R.id.txt_horaires)).setText(horaires);
        ((TextView) findViewById(R.id.txt_adresse)).setText(adresse);
        ((EditText) findViewById(R.id.txt_commentaire)).setText(commentaire);
        ((RatingBar) findViewById(R.id.bar_note)).setRating(nbr_etoiles);


    }


    private View.OnClickListener click = new View.OnClickListener() {
        public void onClick(View v) {
            switch (v.getId()) {
                case R.id.btn_envoyer : //gestion du click du radiobouton Cours collectif

                    //chargement des visites
                    new Update().execute();

                    commentaire = ((EditText)findViewById(R.id.txt_commentaire)).getText().toString();
                    note = String.valueOf(Math.round(((RatingBar) findViewById(R.id.bar_note)).getRating()));

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

    class Update extends AsyncTask<String, String, String> {

        // Before starting background thread Show Progress Dialog
        @Override
        protected void onPreExecute() {
            super.onPreExecute();
            pDialog = new ProgressDialog(Hebergement_Activity.this);
            pDialog.setMessage(getString(R.string.chargement_update));
            pDialog.setIndeterminate(false);
            pDialog.setCancelable(false);
            pDialog.show();
        }


        // getting All visites from url
        protected String doInBackground(String... args) {


            // Building Parameters
            List<NameValuePair> params = new ArrayList<NameValuePair>();
            params.add(new BasicNameValuePair("id", id_v));
            params.add(new BasicNameValuePair("note", note));
            params.add(new BasicNameValuePair("commentaire", commentaire));

            // getting JSON string from URL
            JSONObject json = jParser.makeHttpRequest(update, "GET", params);

            // Check your log cat for JSON reponse
            Log.d("Log : ", json.toString());

            try {
                // Checking for SUCCESS TAG
                int success = json.getInt("success");

                if (success == 1) {
                    // Connexion valide

                    Intent i = new Intent(getApplicationContext(), Planning_Activity.class);
                    i.putExtra("idInspecteur", id_i);
                    startActivity(i);

                } else {
                    // Erreur
                    // Launch Add New product Activity
                    //Intent i = new Intent(getApplicationContext(), Planning_Activity.class);
                    // Closing all previous activities
                    // i.addFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP);
                    //startActivity(i);
                    //Toast.makeText(getApplicationContext(), "Pas de visite", Toast.LENGTH_SHORT).show();
                }
            } catch (JSONException e) {
                e.printStackTrace();
            }

            return null;
        }

        //After completing background task Dismiss the progress dialog
        protected void onPostExecute(String file_url) {
            // dismiss the dialog after getting all products
            pDialog.dismiss();
            // updating UI from Background Thread
            runOnUiThread(new Runnable() {


                public void run() {
                    //Updating parsed JSON data into ListView

                    Toast.makeText(getApplicationContext(), getString(R.string.update_fini), Toast.LENGTH_SHORT).show();
                }



            });
        }
    }
}

