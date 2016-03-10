package com.example.ppe.starsup;

import android.os.Environment;

import com.db4o.Db4oEmbedded;
import com.db4o.ObjectContainer;
import com.db4o.ObjectSet;

import java.io.File;
import java.util.ArrayList;

/**
 * Created by bouhours on 18/12/2015.
 */
public class Modele {
    private String db4oFileName;
    private ObjectContainer dataBase;
    private File appDir;

    public void open() {
        db4oFileName = Environment.getExternalStorageDirectory() + "/baseDB4o" + "/BaseStartsUp.db4o";
        dataBase = Db4oEmbedded.openFile(Db4oEmbedded.newConfiguration(),db4oFileName);
    }

    public void createDirectory() {
        appDir = new File(Environment.getExternalStorageDirectory() + "/baseDB4o");
        if (!appDir.exists() && !appDir.isDirectory()) {
            appDir.mkdirs();
        }
    }

    public Modele() {
        createDirectory();
    }

    public void saveVisite(VISITE uneVisite) {
        try {
            open();
            dataBase.store(uneVisite);
            dataBase.commit();  // VALIDATION de l'ajout, le store s'est bien passé
        }catch(Exception e){
            e.printStackTrace();
            dataBase.rollback();// ANNULATION de l'ajout, le store a "buggé"
        }finally {
            dataBase.close();   // FERMETURE de la BDDO
        }
    }

    public ArrayList<HEBERGEMENT> listeHebergements(){//Retourne la liste des hebergements
        open();
        ArrayList<HEBERGEMENT> listeHebergements = new ArrayList<HEBERGEMENT>();
        ObjectSet<HEBERGEMENT> result = dataBase.queryByExample(HEBERGEMENT.class);
        while (result.hasNext()) {  //Ajoute chaque ligne dans la liste
            listeHebergements.add(result.next());
        }
        dataBase.close();           //Ferme la BDDO
        return listeHebergements;   //Retourner la liste
    }
}
