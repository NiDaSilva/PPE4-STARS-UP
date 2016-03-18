package com.example.ppe.starsup;

/**
 * Created by bouhours on 18/03/2016.
 */


import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

import org.apache.http.NameValuePair;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import android.app.ListActivity;
import android.app.ProgressDialog;
import android.content.Intent;
import android.os.AsyncTask;
import android.util.Log;
import android.widget.ListAdapter;
import android.widget.SimpleAdapter;


public class AllHebergementActivity extends ListActivity {

    // Progress Dialog
    private ProgressDialog pDialog;

    // Creating JSON Parser object
    JSONParser jParser = new JSONParser();

    ArrayList<HashMap<String, String>> productsList;

    // url to get all products list
    private static String connexion_inspecteur = "./connexion_inspecteur.php";

    // JSON Node names
    private static final String TAG_SUCCESS = "success";
    private static final String TAG_INSPECT = "inspecteur";
    private static final String TAG_ID = "id";
    private static final String TAG_NAME = "name";

    // products JSONArray
    JSONArray inspecteur = null;

    /**
     * Background Async Task to Load all product by making HTTP Request
     * */
    class LoadAllProducts extends AsyncTask<String, String, String> {

        /**
         * Before starting background thread Show Progress Dialog
         * */
        @Override
        protected void onPreExecute() {
            super.onPreExecute();
            pDialog = new ProgressDialog(AllHebergementActivity.this);
            pDialog.setMessage("Loading products. Please wait...");
            pDialog.setIndeterminate(false);
            pDialog.setCancelable(false);
            pDialog.show();
        }


        /**
     * getting All products from url
     * */
    protected String doInBackground(String... args) {
        // Building Parameters
        List<NameValuePair> params = new ArrayList<NameValuePair>();
        // getting JSON string from URL
        JSONObject json = jParser.makeHttpRequest(connexion_inspecteur, "GET", params);

        // Check your log cat for JSON reponse
        Log.d("All Products: ", json.toString());

        try {
            // Checking for SUCCESS TAG
            int success = json.getInt(TAG_SUCCESS);

            if (success == 1) {
                // products found
                // Getting Array of Products
                inspecteur = json.getJSONArray(TAG_INSPECT);

                // looping through All Products
                for (int i = 0; i < inspecteur.length(); i++) {
                    JSONObject c = inspecteur.getJSONObject(i);

                    // Storing each json item in variable
                    String id = c.getString(TAG_ID);;

                    // creating new HashMap
                    HashMap<String, String> map = new HashMap<String, String>();

                    // adding each child node to HashMap key => value
                    map.put(TAG_ID, id);

                    // adding HashList to ArrayList
                    productsList.add(map);
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
     * **/
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
                        AllHebergementActivity.this, productsList,
                        R.layout.list_item, new String[] { TAG_ID,TAG_NAME},
                        new int[] { R.id.id, R.id.name });
                // updating listview
                setListAdapter(adapter);
            }
        });

    }

}
