package com.example.ppe.starsup;

import java.util.Date;

/**
 * Created by menant on 18/12/2015.
 */
public class INSPECTEUR {

    private Integer ID_INSPECTEUR;
    private Integer ID_SPECIALITE;
    private String NOM_INSPECTEUR;
    private String PERNOM_INSPECTEUR;
    private String LOGIN;
    private String MDP;

    //region CONSTRUCTEUR
    public INSPECTEUR(){

    }
    public INSPECTEUR(Integer id_inspecteur, Integer id_specialite, String nom, String prenom, String login, String mdp){
        ID_INSPECTEUR = id_inspecteur;
        ID_SPECIALITE = id_specialite;
        NOM_INSPECTEUR = nom;
        PERNOM_INSPECTEUR = prenom ;
        LOGIN = login ;
        MDP = mdp ;

    }

    public Integer getID_SPECIALITE() {
        return ID_SPECIALITE;
    }

    public void setID_SPECIALITE(Integer ID_SPECIALITE) {
        this.ID_SPECIALITE = ID_SPECIALITE;
    }

    public String getNOM_INSPECTEUR() {
        return NOM_INSPECTEUR;
    }

    public void setNOM_INSPECTEUR(String NOM_INSPECTEUR) {
        this.NOM_INSPECTEUR = NOM_INSPECTEUR;
    }

    public String getPERNOM_INSPECTEUR() {
        return PERNOM_INSPECTEUR;
    }

    public void setPERNOM_INSPECTEUR(String PERNOM_INSPECTEUR) {
        this.PERNOM_INSPECTEUR = PERNOM_INSPECTEUR;
    }

    public String getLOGIN() {
        return LOGIN;
    }

    public void setLOGIN(String LOGIN) {
        this.LOGIN = LOGIN;
    }

    public String getMDP() {
        return MDP;
    }

    public void setMDP(String MDP) {
        this.MDP = MDP;
    }
    //endregion
}