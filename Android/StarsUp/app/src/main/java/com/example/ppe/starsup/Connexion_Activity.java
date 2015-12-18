package com.example.ppe.starsup;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import java.io.Serializable;
import java.sql.Date;
import java.text.ParseException;
import java.text.SimpleDateFormat;


public class Connexion_Activity extends Activity {

    private Intent i;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_connexion);

        Button btnL = (Button) findViewById(R.id.btn_login);
        btnL.setOnClickListener(click);
    }

    private View.OnClickListener click = new View.OnClickListener() {
        //redéfinition de la méthode onClick
        public void onClick(View v) {
            switch (v.getId()) {
                case R.id.btn_login : //gestion du click du bouton
                    Toast.makeText(getApplicationContext(), "Connexion ...", Toast.LENGTH_SHORT).show();

                        String email = ((EditText)findViewById(R.id.txt_Email)).getText().toString();
                        String mdp = ((EditText)findViewById(R.id.txt_MDP)).getText().toString();

                        //if login est bon
                            i = new Intent(getApplicationContext(), Planning_Activity.class);
                            startActivity(i);
                            Toast.makeText(getApplicationContext(),"Valide",Toast.LENGTH_SHORT).show();

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
}
