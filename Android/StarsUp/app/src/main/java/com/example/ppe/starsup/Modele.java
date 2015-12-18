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
        db4oFileName = Environment.getExternalStorageDirectory() + "/baseDB4o" + "/BaseCours.db4o";
        Db4oEmbedded.openFile(Db4oEmbedded.newConfiguration(),db4oFileName);
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

    public void saveVisite(Visite_Activity uneVisite) {
        try {
            open();
            dataBase.store(uneVisite);
            dataBase.commit();// VALIDATION de cet ajout d'objet car le store s'est bien passé
        }catch(Exception e){
            e.printStackTrace();
            dataBase.rollback();// ANNULATION de cet ajout d'objet car le store a "buggé"
        }finally {
            dataBase.close();// dans tous les cas FERMETURE de la BDDO
        }
    }

    public ArrayList<Hebergement_Activity> listeHebergement(){
//créer la liste de retour
        open();
        ObjectSet<Hebergement_Activity> result = dataBase.queryByExample(Hebergement_Activity.class);
//parcourir tous les éléments du résultat de la requête et ajouter chaque élément à la nouvelle liste
//fermer la BDDO
//retourner la liste
        return;
    }
}
