package com.example.ppe.starsup;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

import org.apache.http.NameValuePair;
import org.apache.http.message.BasicNameValuePair;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import android.app.ListActivity;
import android.app.ProgressDialog;
import android.content.Intent;
import android.os.AsyncTask;
import android.util.Log;
import android.widget.ListAdapter;
import android.widget.ListView;
import android.widget.SimpleAdapter;


public class AllVisitesActivity extends ListActivity {

    // Progress Dialog
    private ProgressDialog pDialog;

    // Creating JSON Parser object
    JSONParser jParser = new JSONParser();

    //Liste des visites
    ArrayList<HashMap<String, String>> listVisite = new ArrayList<HashMap<String, String>>();

    // url to get all products list
    private static String get_visite = "./get_visite.php";


    // products JSONArray
    JSONArray visites = null;

    //chargement des visites
    //new AllVisitesActivity().execute();

    ListView list_visite = (ListView) findViewById(R.id.list_visites);

    /**
     * Background Async Task to Load all product by making HTTP Request
     */
    class ChargementVisite extends AsyncTask<String, String, String> {

        // Before starting background thread Show Progress Dialog
        @Override
        protected void onPreExecute() {
            super.onPreExecute();
            pDialog = new ProgressDialog(AllVisitesActivity.this);
            pDialog.setMessage("Chargement des visites. Attendez ...");
            pDialog.setIndeterminate(false);
            pDialog.setCancelable(false);
            pDialog.show();
        }


        // getting All visites from url
        protected String doInBackground(String... args) {
            String idInspecteur = "4";

            // Building Parameters
            List<NameValuePair> params = new ArrayList<NameValuePair>();
            params.add(new BasicNameValuePair("id", idInspecteur));

            // getting JSON string from URL
            JSONObject json = jParser.makeHttpRequest(get_visite, "GET", params);

            // Check your log cat for JSON reponse
            Log.d("Visites : ", json.toString());

            try {
                // Checking for SUCCESS TAG
                int success = json.getInt("success");

                if (success == 1) {
                    // visites trouvées
                    // Getting Array of Products
                    visites = json.getJSONArray("visites");

                    // looping through All Products
                    for (int i = 0; i < visites.length(); i++) {
                        JSONObject v = visites.getJSONObject(i);

                        // creating new HashMap
                        HashMap<String, String> map = new HashMap<String, String>();

                        // adding each child node to HashMap key => value
                        map.put("nom", v.getString("nom"));
                        map.put("adresse", v.getString("adresse") + " " + v.getString("ville"));
                        map.put("date", v.getString("horaire"));

                        // adding HashList to ArrayList
                        listVisite.add(map);
                    }
                } else {
                    // no products found
                    // Launch Add New product Activity
                    Intent i = new Intent(getApplicationContext(), Planning_Activity.class);
                    // Closing all previous activities
                    i.addFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP);
                    startActivity(i);
                }
            } catch (JSONException e) {
                e.printStackTrace();
            }

            return null;
        }

        /**
         * After completing background task Dismiss the progress dialog
         * *
         */
        protected void onPostExecute(String file_url) {
            // dismiss the dialog after getting all products
            pDialog.dismiss();
            // updating UI from Background Thread
            runOnUiThread(new Runnable() {
                public void run() {
                    /**
                     * Updating parsed JSON data into ListView
                     * */
                    ListAdapter adapter = new SimpleAdapter(
                            AllVisitesActivity.this, listVisite, R.layout.list_planning, new String[]{"date", "nom", "adresse"}, new int[]{R.id.date, R.id.nom, R.id.adresse});
                    // updating listview
                    setListAdapter(adapter);
                }
            });

        }

    }
}
