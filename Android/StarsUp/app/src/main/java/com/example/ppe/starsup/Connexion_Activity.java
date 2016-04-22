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
import android.widget.ListAdapter;
import android.widget.SimpleAdapter;
import android.widget.Toast;

import org.apache.http.NameValuePair;
import org.apache.http.message.BasicNameValuePair;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.io.Serializable;
import java.sql.Date;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;


public class Connexion_Activity extends Activity {

    // Progress Dialog
    private ProgressDialog pDialog;

    // Creating JSON Parser object
    JSONParser jParser = new JSONParser();

    // products JSONArray
    JSONArray Inspecteur = null;

    // url to get all products list
    private static String connexion = "http://192.168.215.10/Android/connexion_inspecteur.php";

    String login;
    String mdp;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_connexion);

        Button btnLogin = (Button) findViewById(R.id.btn_login);
        btnLogin.setOnClickListener(click);
    }

    private View.OnClickListener click = new View.OnClickListener() {
        //redéfinition de la méthode onClick
        public void onClick(View v) {
            switch (v.getId()) {
                case R.id.btn_login : //gestion du click du bouton

                    //chargement des visites
                    new Connexion().execute();

                    //Toast.makeText(getApplicationContext(), "Connexion ...", Toast.LENGTH_SHORT).show();

                    login = ((EditText)findViewById(R.id.txt_Login)).getText().toString();
                    mdp = ((EditText)findViewById(R.id.txt_MDP)).getText().toString();

                        //if login est bon
                        //    Intent i = new Intent(getApplicationContext(), Planning_Activity.class);
                        //    Toast.makeText(getApplicationContext(),"Valide",Toast.LENGTH_SHORT).show();
                        //    startActivity(i);
                    break;
            }
        }
    };

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_connexion, menu);
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

    class Connexion extends AsyncTask<String, String, String> {

        // Before starting background thread Show Progress Dialog
        @Override
        protected void onPreExecute() {
            super.onPreExecute();
            pDialog = new ProgressDialog(Connexion_Activity.this);
            pDialog.setMessage("Connexion en cours. Attendez ...");
            pDialog.setIndeterminate(false);
            pDialog.setCancelable(false);
            pDialog.show();
        }


        // getting All visites from url
        protected String doInBackground(String... args) {


            // Building Parameters
            List<NameValuePair> params = new ArrayList<NameValuePair>();
            params.add(new BasicNameValuePair("login", login));
            params.add(new BasicNameValuePair("mdp", mdp));

            // getting JSON string from URL
            JSONObject json = jParser.makeHttpRequest(connexion, "GET", params);

            // Check your log cat for JSON reponse
            Log.d("Log : ", json.toString());

            try {
                // Checking for SUCCESS TAG
                int success = json.getInt("success");

                if (success == 1) {
                    // Connexion valide
                    // Getting Array of Products
                    Inspecteur = json.getJSONArray("inspecteur");

                    // looping through All Products
                    JSONObject v = Inspecteur.getJSONObject(0);

                    Intent i = new Intent(getApplicationContext(), Planning_Activity.class);
                    i.putExtra("idInspecteur", v.getString("id"));

                    //Toast.makeText(getApplicationContext(), "Valide", Toast.LENGTH_SHORT).show();
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

                    //Insertion des items dans la vue list_planning
                }



            });
        }
    }
}
