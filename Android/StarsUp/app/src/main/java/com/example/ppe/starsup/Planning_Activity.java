package com.example.ppe.starsup;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ListView;
import android.widget.SimpleAdapter;

import java.util.ArrayList;
import java.util.HashMap;


public class Planning_Activity extends Activity {

    private HEBERGEMENT hebergement;
    private Modele BaseStartsUp;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_planning);

        ListView list_visite = (ListView) findViewById(R.id.list_visites);

        //ArrayList<HEBERGEMENT> listeHebergements = BaseStartsUp.listeHebergements();    //Liste des visites à faire

        //ArrayAdapter<HEBERGEMENT> adapter = new ArrayAdapter<HEBERGEMENT>(this, android.R.layout.simple_list_item_1, listeHebergements);*/

        //ArrayList qui remplit la list_visite
        ArrayList<HashMap<String, String>> listItem = new ArrayList<HashMap<String, String>>();

        //HashMap de test
        HashMap<String, String> map;

        map = new HashMap<String, String>();
        map.put("nom", "Hotel F1");
        map.put("adresse", "1 Rue de Test");
        map.put("date", "09H00");
        listItem.add(map);

        map = new HashMap<String, String>();
        map.put("nom", "Hotel Ibis");
        map.put("adresse", "24 Rue de la Place");
        map.put("date", "11H30");
        listItem.add(map);

        map = new HashMap<String, String>();
        map.put("nom", "Camping municipal");
        map.put("adresse", "Chemin du General");
        map.put("date", "15H00");
        listItem.add(map);

        map = new HashMap<String, String>();
        map.put("nom", "Maison d'hote Dupond");
        map.put("adresse", "48 Avenue Foch");
        map.put("date", "17H30");
        listItem.add(map);

        //Insertion des items dans la vue list_planning
        SimpleAdapter adapter = new SimpleAdapter(this.getBaseContext(), listItem, R.layout.list_planning,
                new String[] {"date", "nom", "adresse"}, new int[] {R.id.date, R.id.nom, R.id.adresse});

        list_visite.setAdapter(adapter);

        //OnClick
        list_visite.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> a, View v, int position, long id) {
                Intent i = new Intent(getApplicationContext(), Hebergement_Activity.class);
                startActivity(i);
            }
        });
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_planning, menu);
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
