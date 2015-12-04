DROP DATABASE IF EXISTS PPE4;

CREATE DATABASE IF NOT EXISTS PPE4;
USE PPE4;
# -----------------------------------------------------------------------------
#       TABLE : HEBERGEMENT
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS HEBERGEMENT
 (
   ID_HEBERGEMENT INTEGER NOT NULL  ,
   ID_DEPARTEMENT INTEGER NOT NULL  ,
   NOM_HEBERGEMENT VARCHAR(128) NULL  ,
   ADRESSE_HEBERGEMENT VARCHAR(128) NULL  ,
   VILLE_HEBERGEMENT VARCHAR(128) NULL  
   , PRIMARY KEY (ID_HEBERGEMENT) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE HEBERGEMENT
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_HEBERGEMENT_DEPARTEMENT
     ON HEBERGEMENT (ID_DEPARTEMENT ASC);

# -----------------------------------------------------------------------------
#       TABLE : SAISON
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS SAISON
 (
   ID_SAISON INTEGER NOT NULL  ,
   LIBELLE_SAISON VARCHAR(128) NULL  
   , PRIMARY KEY (ID_SAISON) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : CHAMBRE_HOTE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS CHAMBRE_HOTE
 (
   ID_HEBERGEMENT INTEGER NOT NULL  ,
   NOMBRE_CHAMBRE_HOTE SMALLINT NULL  ,
   CUISINE_CHAMBRE_HOTE BOOLEAN NULL  ,
   NOM_HEBERGEMENT VARCHAR(128) NULL  ,
   ADRESSE_HEBERGEMENT VARCHAR(128) NULL  ,
   VILLE_HEBERGEMENT VARCHAR(128) NULL  
   , PRIMARY KEY (ID_HEBERGEMENT) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : DEPARTEMENT
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS DEPARTEMENT
 (
   ID_DEPARTEMENT INTEGER NOT NULL  ,
   LIBELLE_DEPARTEMENT VARCHAR(128) NULL  
   , PRIMARY KEY (ID_DEPARTEMENT) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : SPECIALITE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS SPECIALITE
 (
   ID_SPECIALITE INTEGER NOT NULL  ,
   LIBELLE_SPECIALITE VARCHAR(128) NULL  
   , PRIMARY KEY (ID_SPECIALITE) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : EQUIPEMENT_CAMPING
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS EQUIPEMENT_CAMPING
 (
   ID_EQUIPEMENT_CAMPING INTEGER NOT NULL  ,
   LIBELLE_EQUIPEMENT_CAMPING VARCHAR(128) NULL  
   , PRIMARY KEY (ID_EQUIPEMENT_CAMPING) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : CAMPING
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS CAMPING
 (
   ID_HEBERGEMENT INTEGER NOT NULL  ,
   NOM_HEBERGEMENT VARCHAR(128) NULL  ,
   ADRESSE_HEBERGEMENT VARCHAR(128) NULL  ,
   VILLE_HEBERGEMENT VARCHAR(128) NULL  
   , PRIMARY KEY (ID_HEBERGEMENT) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : TYPE_CUISINE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS TYPE_CUISINE
 (
   ID_TYPE_CUISINE INTEGER NOT NULL  ,
   LIBELLE_TYPE_CUISINE INTEGER NULL  
   , PRIMARY KEY (ID_TYPE_CUISINE) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : HOTEL
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS HOTEL
 (
   ID_HEBERGEMENT INTEGER NOT NULL  ,
   RESTAURANT_HOTEL BOOLEAN NULL  ,
   CHEF_RESTAURANT_HOTEL VARCHAR(128) NULL  ,
   NOM_HEBERGEMENT VARCHAR(128) NULL  ,
   ADRESSE_HEBERGEMENT VARCHAR(128) NULL  ,
   VILLE_HEBERGEMENT VARCHAR(128) NULL  
   , PRIMARY KEY (ID_HEBERGEMENT) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : GERANT
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS GERANT
 (
   ID_GERANT INTEGER NOT NULL  ,
   NOM_GERANT VARCHAR(128) NULL  ,
   PRENOM_GERANT VARCHAR(128) NULL  
   , PRIMARY KEY (ID_GERANT) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : INSPECTEUR
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS INSPECTEUR
 (
   ID_INSPECTEUR INTEGER NOT NULL  ,
   ID_SPECIALITE INTEGER NOT NULL  ,
   NOM_INSPECTEUR VARCHAR(128) NULL  ,
   PERNOM_INSPECTEUR VARCHAR(128) NULL  
   , PRIMARY KEY (ID_INSPECTEUR) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE INSPECTEUR
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_INSPECTEUR_SPECIALITE
     ON INSPECTEUR (ID_SPECIALITE ASC);

# -----------------------------------------------------------------------------
#       TABLE : GERER
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS GERER
 (
   ID_HEBERGEMENT INTEGER NOT NULL  ,
   ID_GERANT INTEGER NOT NULL  
   , PRIMARY KEY (ID_HEBERGEMENT,ID_GERANT) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE GERER
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_GERER_HEBERGEMENT
     ON GERER (ID_HEBERGEMENT ASC);

CREATE  INDEX I_FK_GERER_GERANT
     ON GERER (ID_GERANT ASC);

# -----------------------------------------------------------------------------
#       TABLE : AVOIR
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS AVOIR
 (
   ID_TYPE_CUISINE INTEGER NOT NULL  ,
   ID_HEBERGEMENT INTEGER NOT NULL  
   , PRIMARY KEY (ID_TYPE_CUISINE,ID_HEBERGEMENT) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE AVOIR
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_AVOIR_TYPE_CUISINE
     ON AVOIR (ID_TYPE_CUISINE ASC);

CREATE  INDEX I_FK_AVOIR_HOTEL
     ON AVOIR (ID_HEBERGEMENT ASC);

# -----------------------------------------------------------------------------
#       TABLE : POSSEDER
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS POSSEDER
 (
   ID_EQUIPEMENT_CAMPING INTEGER NOT NULL  ,
   ID_HEBERGEMENT INTEGER NOT NULL  
   , PRIMARY KEY (ID_EQUIPEMENT_CAMPING,ID_HEBERGEMENT) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE POSSEDER
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_POSSEDER_EQUIPEMENT_CAMPING
     ON POSSEDER (ID_EQUIPEMENT_CAMPING ASC);

CREATE  INDEX I_FK_POSSEDER_CAMPING
     ON POSSEDER (ID_HEBERGEMENT ASC);

# -----------------------------------------------------------------------------
#       TABLE : VISITER
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS VISITER
 (
   ID_HEBERGEMENT INTEGER NOT NULL  ,
   ID_INSPECTEUR INTEGER NOT NULL  ,
   ID_SAISON INTEGER NOT NULL  ,
   NOMBRE_ETOILE_VISITE SMALLINT NULL  ,
   DATE_HEURE_VISITE DATETIME NULL  ,
   CONTRE_VISITE BOOLEAN NULL  ,
   COMMENTAIRE_VISITE VARCHAR(255) NULL  ,
   TYPE_VISITE BOOLEAN NULL  
   , PRIMARY KEY (ID_HEBERGEMENT,ID_INSPECTEUR,ID_SAISON) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE VISITER
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_VISITER_HEBERGEMENT
     ON VISITER (ID_HEBERGEMENT ASC);

CREATE  INDEX I_FK_VISITER_INSPECTEUR
     ON VISITER (ID_INSPECTEUR ASC);

CREATE  INDEX I_FK_VISITER_SAISON
     ON VISITER (ID_SAISON ASC);


# -----------------------------------------------------------------------------
#       CREATION DES REFERENCES DE TABLE
# -----------------------------------------------------------------------------


ALTER TABLE HEBERGEMENT 
  ADD FOREIGN KEY FK_HEBERGEMENT_DEPARTEMENT (ID_DEPARTEMENT)
      REFERENCES DEPARTEMENT (ID_DEPARTEMENT) ;


ALTER TABLE CHAMBRE_HOTE 
  ADD FOREIGN KEY FK_CHAMBRE_HOTE_HEBERGEMENT (ID_HEBERGEMENT)
      REFERENCES HEBERGEMENT (ID_HEBERGEMENT) ;


ALTER TABLE CAMPING 
  ADD FOREIGN KEY FK_CAMPING_HEBERGEMENT (ID_HEBERGEMENT)
      REFERENCES HEBERGEMENT (ID_HEBERGEMENT) ;


ALTER TABLE HOTEL 
  ADD FOREIGN KEY FK_HOTEL_HEBERGEMENT (ID_HEBERGEMENT)
      REFERENCES HEBERGEMENT (ID_HEBERGEMENT) ;


ALTER TABLE INSPECTEUR 
  ADD FOREIGN KEY FK_INSPECTEUR_SPECIALITE (ID_SPECIALITE)
      REFERENCES SPECIALITE (ID_SPECIALITE) ;


ALTER TABLE GERER 
  ADD FOREIGN KEY FK_GERER_HEBERGEMENT (ID_HEBERGEMENT)
      REFERENCES HEBERGEMENT (ID_HEBERGEMENT) ;


ALTER TABLE GERER 
  ADD FOREIGN KEY FK_GERER_GERANT (ID_GERANT)
      REFERENCES GERANT (ID_GERANT) ;


ALTER TABLE AVOIR 
  ADD FOREIGN KEY FK_AVOIR_TYPE_CUISINE (ID_TYPE_CUISINE)
      REFERENCES TYPE_CUISINE (ID_TYPE_CUISINE) ;


ALTER TABLE AVOIR 
  ADD FOREIGN KEY FK_AVOIR_HOTEL (ID_HEBERGEMENT)
      REFERENCES HOTEL (ID_HEBERGEMENT) ;


ALTER TABLE POSSEDER 
  ADD FOREIGN KEY FK_POSSEDER_EQUIPEMENT_CAMPING (ID_EQUIPEMENT_CAMPING)
      REFERENCES EQUIPEMENT_CAMPING (ID_EQUIPEMENT_CAMPING) ;


ALTER TABLE POSSEDER 
  ADD FOREIGN KEY FK_POSSEDER_CAMPING (ID_HEBERGEMENT)
      REFERENCES CAMPING (ID_HEBERGEMENT) ;


ALTER TABLE VISITER 
  ADD FOREIGN KEY FK_VISITER_HEBERGEMENT (ID_HEBERGEMENT)
      REFERENCES HEBERGEMENT (ID_HEBERGEMENT) ;


ALTER TABLE VISITER 
  ADD FOREIGN KEY FK_VISITER_INSPECTEUR (ID_INSPECTEUR)
      REFERENCES INSPECTEUR (ID_INSPECTEUR) ;


ALTER TABLE VISITER 
  ADD FOREIGN KEY FK_VISITER_SAISON (ID_SAISON)
      REFERENCES SAISON (ID_SAISON) ;

