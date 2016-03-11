package com.example.ppe.starsup;

import android.widget.Toast;

/**
 * Created by bouhours on 11/03/2016.
 */
public class ImportActivity {
    private Modele maBDO;
    public void recupTuplesBDD(String s) {
      /* a la fin du thread (onPostExecute), on appelle cette methode*/
        HEBERGEMENT hebergement;
        VISITE visite ;
        INSPECTEUR inspecteur;
        maBDO = new Modele();
        Toast.makeText(getApplicationContext(), "suppression des cours EXISTANTS dans DB4O",Toast.LENGTH_LONG).show();
                JsonElement json = new JsonParser().parse(s.toString());
        JsonArray varray = json.getAsJsonArray();
        Gson gson = new GsonBuilder().setDateFormat("yyyy-mm-dd").create();
        for(JsonElement obj : varray )
        {
//ATTENTION : les champs de la BDD doivent avoir le MEME NOM nom que les proprietes de la classe
//sinon CORRESPONDANCE IMPOSSIBLE
            vCoursI = gson.fromJson(obj.getAsJsonObject(),CoursIndividuels.class);
            Toast.makeText(getApplicationContext(),vCoursI.toString(),Toast.LENGTH_LONG).show();
            maBDO.save(vCoursI);
        }
        Toast.makeText(getApplicationContext(),"FIN de l'IMPORT",Toast.LENGTH_LONG).show();
        finish();
    }
}
