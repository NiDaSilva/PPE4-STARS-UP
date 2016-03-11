<?php

class mypdo extends PDO
{
    private $PARAM_hote = 'localhost'; // le chemin vers le serveur
    private $PARAM_utilisateur = 'root'; // nom d'utilisateur pour se connecter
    private $PARAM_mot_passe = ''; // mot de passe de l'utilisateur pour se connecter
    private $PARAM_nom_bd = 'ppe4';

    private $connexion;

    public function __construct()
    {
        try {

            $this->connexion = new PDO('mysql:host=' . $this->PARAM_hote . ';dbname=' . $this->PARAM_nom_bd, $this->PARAM_utilisateur, $this->PARAM_mot_passe, array(PDO::MYSQL_ATTR_INIT_COMMAND => 'SET NAMES utf8'));
            //echo '<script>alert ("ok connex");</script>)';echo $this->PARAM_nom_bd;
        } catch (PDOException $e) {
            echo 'hote: ' . $this->PARAM_hote . ' ' . $_SERVER['DOCUMENT_ROOT'] . '<br />';
            echo 'Erreur : ' . $e->getMessage() . '<br />';
            echo 'N° : ' . $e->getCode();
            $this->connexion = false;
            //echo '<script>alert ("pbs acces bdd");</script>)';
        }
    }

    public function __get($propriete)
    {
        switch ($propriete) {
            case 'connexion' : {
                return $this->connexion;
                break;
            }
        }
    }

    public function connect($tab)
    {
        if ($tab['categ'] == 'admin') {
            $requete = 'select * from admin where LOGIN="' . $tab['id'] . '" and MDP=MD5("' . $tab['mp'] . '");';
        }
        if ($tab['categ'] == 'inspecteur') {
            $requete = 'select * from inspecteur where LOGIN="' . $tab['id'] . '" and MDP=MD5("' . $tab['mp'] . '");';
        }
        if ($tab['categ'] == 'gerant') {
            $requete = 'select * from gerant where LOGIN="' . $tab['id'] . '" and MDP=MD5("' . $tab['mp'] . '");';
        }
        $result = $this->connexion->query($requete);
        if ($result) {
            if ($result->rowCount() == 1) {
                return ($result);
            }
        }
        return null;
    }

    public function return_hebergement()
    {
        $requete = 'SELECT * FROM hebergement;';
        $result = $this->connexion->query($requete);
        if ($result) {
            if ($result->rowCount() >= 1) {
                return ($result);
            }
        }
    }
}