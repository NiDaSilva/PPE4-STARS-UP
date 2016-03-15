package com.example.ppe.starsup;

import java.util.Date;

/**
 * Created by menant on 18/12/2015.
 */
public class VISITE {

    private Integer ID_HEBERGEMENT;
    private Integer ID_INSPECTEUR;
    private Integer ID_SAISON;
    private Integer NOMBRE_ETOILE_VISITE;
    private Integer CONTRE_VISITE_CHECKED;
    private Date DATE_HEURE_VISITE;
    private String COMMENTAIRE_VISTE;

    //region accesseur
    public Integer getID_HEBERGEMENT() {
        return ID_HEBERGEMENT;
    }

    public void setID_HEBERGEMENT(Integer ID_HEBERGEMENT) {
        this.ID_HEBERGEMENT = ID_HEBERGEMENT;
    }

    public Integer getID_INSPECTEUR() {
        return ID_INSPECTEUR;
    }

    public void setID_INSPECTEUR(Integer ID_INSPECTEUR) {
        this.ID_INSPECTEUR = ID_INSPECTEUR;
    }

    public Integer getID_SAISON() {
        return ID_SAISON;
    }

    public void setID_SAISON(Integer ID_SAISON) {
        this.ID_SAISON = ID_SAISON;
    }

    public Integer getNOMBRE_ETOILE_VISITE() {
        return NOMBRE_ETOILE_VISITE;
    }

    public void setNOMBRE_ETOILE_VISITE(Integer NOMBRE_ETOILE_VISITE) {
        this.NOMBRE_ETOILE_VISITE = NOMBRE_ETOILE_VISITE;
    }

    public Integer getCONTRE_VISITE_CHECKED() {
        return CONTRE_VISITE_CHECKED;
    }

    public void setCONTRE_VISITE_CHECKED(Integer CONTRE_VISITE_CHECKED) {
        this.CONTRE_VISITE_CHECKED = CONTRE_VISITE_CHECKED;
    }


    public Date getDATE_HEURE_VISITE() {
        return DATE_HEURE_VISITE;
    }

    public void setDATE_HEURE_VISITE(Date DATE_HEURE_VISITE) {
        this.DATE_HEURE_VISITE = DATE_HEURE_VISITE;
    }

    public String getCOMMENTAIRE_VISTE() {
        return COMMENTAIRE_VISTE;
    }

    public void setCOMMENTAIRE_VISTE(String COMMENTAIRE_VISTE) {
        this.COMMENTAIRE_VISTE = COMMENTAIRE_VISTE;
    }
    //endregion

    //region CONSTRUCTEUR
    public VISITE(){

    }
    public VISITE(Integer unNbEtoile, Integer uneContreVisiste, Integer unType, Date uneD, String unCom ){
        NOMBRE_ETOILE_VISITE = unNbEtoile;
        CONTRE_VISITE_CHECKED = uneContreVisiste;
        COMMENTAIRE_VISTE = unCom ;

    }
    //endregion
}