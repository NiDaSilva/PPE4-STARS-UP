package com.example.ppe.starsup;

/**
 * Created by menant on 18/12/2015.
 */
public class HEBERGEMENT {
    private Integer ID_DEPARTEMENT;
    private Integer ID_HEBERGEMENT;
    private String NOM_HEBERGEMENT;
    private String WEBSITE_HEBERGEMENT;
    private String HORAIRES_HEBERGEMENT;
    private String ADRESSE_HEBERGEMENT;
    private String VILLE_HEBERGEMENT;

    //region accesseur
    public Integer getID_DEPARTEMENT() {
        return ID_DEPARTEMENT;
    }

    public void setID_DEPARTEMENT(Integer ID_DEPARTEMENT) {
        this.ID_DEPARTEMENT = ID_DEPARTEMENT;
    }

    public Integer getID_HEBERGEMENT() {
        return ID_HEBERGEMENT;
    }

    public void setID_HEBERGEMENT(Integer ID_HEBERGEMENT) {
        this.ID_HEBERGEMENT = ID_HEBERGEMENT;
    }

    public String getNOM_HEBERGEMENT() {
        return NOM_HEBERGEMENT;
    }

    public void setNOM_HEBERGEMENT(String NOM_HEBERGEMENT) {
        this.NOM_HEBERGEMENT = NOM_HEBERGEMENT;
    }

    public String getWEBSITE_HEBERGEMENT() {
        return WEBSITE_HEBERGEMENT;
    }

    public String getHORAIRES_HEBERGEMENT() {
        return HORAIRES_HEBERGEMENT;
    }

    public String getADRESSE_HEBERGEMENT() {
        return ADRESSE_HEBERGEMENT;
    }

    public void setADRESSE_HEBERGEMENT(String ADRESSE_HEBERGEMENT) {
        this.ADRESSE_HEBERGEMENT = ADRESSE_HEBERGEMENT;
    }

    public String getVILLE_HEBERGEMENT() {
        return VILLE_HEBERGEMENT;
    }

    public void setVILLE_HEBERGEMENT(String VILLE_HEBERGEMENT) {
        this.VILLE_HEBERGEMENT = VILLE_HEBERGEMENT;
    }
    //endregion

    //region CONSTRUCTEUR
    public HEBERGEMENT(Integer unDep, String unN, String uneA, String uneV){
        ID_DEPARTEMENT = unDep;
        NOM_HEBERGEMENT = unN;
        ADRESSE_HEBERGEMENT = uneA;
        VILLE_HEBERGEMENT= uneV ;

    }

    public HEBERGEMENT(){

    }
    //endregion

    public String toString(){
        StringBuilder sb = new StringBuilder();
        sb.append("\t departement : ").append(ID_DEPARTEMENT);
        sb.append(" ville : ").append(VILLE_HEBERGEMENT).append("\n");
        sb.append(" adresse : ").append(ADRESSE_HEBERGEMENT ).append("\n");
        sb.append(" nom : ").append(NOM_HEBERGEMENT ).append("\n");
        return sb.toString();
    }


}