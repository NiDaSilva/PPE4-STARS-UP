/*
 ----------------------------------------------------------------------------
             Génération d'une base de données pour
                      Microsoft SQL Server
                       (4/12/2015 15:39:41)
 ----------------------------------------------------------------------------
     Nom de la base : PPE4
     Projet : 
     Auteur : BTS SIO
     Date de dernière modification : 4/12/2015 15:38:16
 ----------------------------------------------------------------------------
*/

drop database PPE4
go

/* -----------------------------------------------------------------------------
      OUVERTURE DE LA BASE PPE4
----------------------------------------------------------------------------- */

create database PPE4
go

use PPE4
go



/* -----------------------------------------------------------------------------
      TABLE : HEBERGEMENT
----------------------------------------------------------------------------- */

create table HEBERGEMENT
(
     ID_HEBERGEMENT char(32) not null,
     ID_DEPARTEMENT int not null,
     NOM_HEBERGEMENT varchar(128) ,
     ADRESSE_HEBERGEMENT varchar(128) ,
     VILLE_HEBERGEMENT varchar(128) 
)
go



/*      INDEX DE HEBERGEMENT      */


sp_primarykey HEBERGEMENT, ID_HEBERGEMENT
go



/* -----------------------------------------------------------------------------
      TABLE : SAISON
----------------------------------------------------------------------------- */

create table SAISON
(
     ID_SAISON int not null,
     LIBELLE_SAISON varchar(128) 
)
go



/*      INDEX DE SAISON      */


sp_primarykey SAISON, ID_SAISON
go



/* -----------------------------------------------------------------------------
      TABLE : CHAMBRE_HÔTE
----------------------------------------------------------------------------- */

create table CHAMBRE_HÔTE
(
     ID_HEBERGEMENT char(32) not null,
     NOMBRE_CHAMBRE_HOTE smallint ,
     CUISINE_CHAMBRE_HOTE bit ,
     NOM_HEBERGEMENT varchar(128) ,
     ADRESSE_HEBERGEMENT varchar(128) ,
     VILLE_HEBERGEMENT varchar(128) 
)
go



/*      INDEX DE CHAMBRE_HÔTE      */


sp_primarykey CHAMBRE_HÔTE, ID_HEBERGEMENT
go



/* -----------------------------------------------------------------------------
      TABLE : DEPARTEMENT
----------------------------------------------------------------------------- */

create table DEPARTEMENT
(
     ID_DEPARTEMENT int not null,
     LIBELLE_DEPARTEMENT varchar(128) 
)
go



/*      INDEX DE DEPARTEMENT      */


sp_primarykey DEPARTEMENT, ID_DEPARTEMENT
go



/* -----------------------------------------------------------------------------
      TABLE : SPECIALITE
----------------------------------------------------------------------------- */

create table SPECIALITE
(
     ID_SPECIALITE int not null,
     LIBELLE_SPECIALITE varchar(128) 
)
go



/*      INDEX DE SPECIALITE      */


sp_primarykey SPECIALITE, ID_SPECIALITE
go



/* -----------------------------------------------------------------------------
      TABLE : EQUIPEMENT_CAMPING
----------------------------------------------------------------------------- */

create table EQUIPEMENT_CAMPING
(
     ID_EQUIPEMENT_CAMPING int not null,
     LIBELLE_EQUIPEMENT_CAMPING varchar(128) 
)
go



/*      INDEX DE EQUIPEMENT_CAMPING      */


sp_primarykey EQUIPEMENT_CAMPING, ID_EQUIPEMENT_CAMPING
go



/* -----------------------------------------------------------------------------
      TABLE : CAMPING
----------------------------------------------------------------------------- */

create table CAMPING
(
     ID_HEBERGEMENT char(32) not null,
     NOM_HEBERGEMENT varchar(128) ,
     ADRESSE_HEBERGEMENT varchar(128) ,
     VILLE_HEBERGEMENT varchar(128) 
)
go



/*      INDEX DE CAMPING      */


sp_primarykey CAMPING, ID_HEBERGEMENT
go



/* -----------------------------------------------------------------------------
      TABLE : TYPE_CUISINE
----------------------------------------------------------------------------- */

create table TYPE_CUISINE
(
     ID_TYPE_CUISINE int not null,
     LIBELLE_TYPE_CUISINE int 
)
go



/*      INDEX DE TYPE_CUISINE      */


sp_primarykey TYPE_CUISINE, ID_TYPE_CUISINE
go



/* -----------------------------------------------------------------------------
      TABLE : HÔTEL
----------------------------------------------------------------------------- */

create table HÔTEL
(
     ID_HEBERGEMENT char(32) not null,
     RESTAURANT_HOTEL bit ,
     CHEF_RESTAURANT_HOTEL varchar(128) ,
     NOM_HEBERGEMENT varchar(128) ,
     ADRESSE_HEBERGEMENT varchar(128) ,
     VILLE_HEBERGEMENT varchar(128) 
)
go



/*      INDEX DE HÔTEL      */


sp_primarykey HÔTEL, ID_HEBERGEMENT
go



/* -----------------------------------------------------------------------------
      TABLE : GÉRANT
----------------------------------------------------------------------------- */

create table GÉRANT
(
     ID_GERANT int not null,
     NOM_GERANT varchar(128) ,
     PRENOM_GERANT varchar(128) 
)
go



/*      INDEX DE GÉRANT      */


sp_primarykey GÉRANT, ID_GERANT
go



/* -----------------------------------------------------------------------------
      TABLE : INSPECTEUR
----------------------------------------------------------------------------- */

create table INSPECTEUR
(
     ID_INSPECTEUR int not null,
     ID_SPECIALITE int not null,
     NOM_INSPECTEUR varchar(128) ,
     PERNOM_INSPECTEUR varchar(128) 
)
go



/*      INDEX DE INSPECTEUR      */


sp_primarykey INSPECTEUR, ID_INSPECTEUR
go



/* -----------------------------------------------------------------------------
      TABLE : GERER
----------------------------------------------------------------------------- */

create table GERER
(
     ID_HEBERGEMENT char(32) not null,
     ID_GERANT int not null
)
go



/*      INDEX DE GERER      */


sp_primarykey GERER, ID_HEBERGEMENT, ID_GERANT
go



/* -----------------------------------------------------------------------------
      TABLE : AVOIR
----------------------------------------------------------------------------- */

create table AVOIR
(
     ID_TYPE_CUISINE int not null,
     ID_HEBERGEMENT char(32) not null
)
go



/*      INDEX DE AVOIR      */


sp_primarykey AVOIR, ID_TYPE_CUISINE, ID_HEBERGEMENT
go



/* -----------------------------------------------------------------------------
      TABLE : POSSEDER
----------------------------------------------------------------------------- */

create table POSSEDER
(
     ID_EQUIPEMENT_CAMPING int not null,
     ID_HEBERGEMENT char(32) not null
)
go



/*      INDEX DE POSSEDER      */


sp_primarykey POSSEDER, ID_EQUIPEMENT_CAMPING, ID_HEBERGEMENT
go



/* -----------------------------------------------------------------------------
      TABLE : VISITER
----------------------------------------------------------------------------- */

create table VISITER
(
     ID_HEBERGEMENT char(32),
     ID_INSPECTEUR int,
     ID_SAISON int,
     NOMBRE_ETOILE_VISITE smallint ,
     DATE_HEURE_VISITE timestamp ,
     CONTRE_VISITE bit ,
     COMMENTAIRE_VISITE varchar(255) ,
     TYPE_VISITE bit 
)
go



/*      INDEX DE VISITER      */


sp_primarykey VISITER, ID_HEBERGEMENT, ID_INSPECTEUR, ID_SAISON
go



/* -----------------------------------------------------------------------------
      REFRENCES SUR LES TABLES
----------------------------------------------------------------------------- */


sp_foreignkey HEBERGEMENT, DEPARTEMENT, ID_DEPARTEMENT
go


sp_foreignkey CHAMBRE_HÔTE, HEBERGEMENT, ID_HEBERGEMENT
go


sp_foreignkey CAMPING, HEBERGEMENT, ID_HEBERGEMENT
go


sp_foreignkey HÔTEL, HEBERGEMENT, ID_HEBERGEMENT
go


sp_foreignkey INSPECTEUR, SPECIALITE, ID_SPECIALITE
go


sp_foreignkey GERER, HEBERGEMENT, ID_HEBERGEMENT
go


sp_foreignkey GERER, GÉRANT, ID_GERANT
go


sp_foreignkey AVOIR, TYPE_CUISINE, ID_TYPE_CUISINE
go


sp_foreignkey AVOIR, HÔTEL, ID_HEBERGEMENT
go


sp_foreignkey POSSEDER, EQUIPEMENT_CAMPING, ID_EQUIPEMENT_CAMPING
go


sp_foreignkey POSSEDER, CAMPING, ID_HEBERGEMENT
go


sp_foreignkey VISITER, HEBERGEMENT, ID_HEBERGEMENT
go


sp_foreignkey VISITER, INSPECTEUR, ID_INSPECTEUR
go


sp_foreignkey VISITER, SAISON, ID_SAISON
go



/*
 -----------------------------------------------------------------------------
               FIN DE GENERATION
 -----------------------------------------------------------------------------
*/