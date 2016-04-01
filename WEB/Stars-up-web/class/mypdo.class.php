<?php

class mypdo extends PDO
{
    private $PARAM_hote = '192.168.215.10'; // le chemin vers le serveur : 192.168.215.10
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

        $requ = $this->connexion->prepare('SELECT * FROM '.$tab["type"].' WHERE LOGIN="'.$tab["id"].'" and MDP="'.$tab["mp"].'";');
        $requ->execute();
        $result = $requ->fetch(PDO::FETCH_ASSOC);
        if($result)
        {
            return ($result);
        }
        return null;
    }

    /****ADMIN****/

    public function count_row($nomtable)
    {
        $requete = 'SELECT * FROM '.$nomtable.';';
        $result = $this->connexion->query($requete);
        return ($result->rowCount());
    }


    public function return_table($nomtable,$cPage,$limit)
    {
        if($limit == 0)
        {
            $requete = 'SELECT * FROM '.$nomtable.';';
        }
        else
        {
            $cPage=($cPage-1)*$limit;
            $requete = 'SELECT * FROM '.$nomtable.' LIMIT '.$cPage.','.$limit.';';
        }
        $result = $this->connexion->query($requete);
        if ($result) {
            if ($result->rowCount() >= 1) {
                return ($result);
            }
        }
    }

    public function insert($tab){
        $requete = 'INSERT INTO hebergement (ID_HEBERGEMENT,ID_DEPARTEMENT, NOM_HEBERGEMENT,ADRESSE_HEBERGEMENT,VILLE_HEBERGEMENT, HORAIRES)
        VALUES('.$tab['id'].','.$tab['departement'].','.$tab['nom'].','.$tab['adresse'].','.$tab['ville'].','.$tab['horaire'].'); ';


        switch ($tab['table']) {
            case 'hotel':
            {
                $requete = $requete. 'INSERT INTO hotel VALUES('.$tab['id'].','.$tab['nbresto'].','.$tab['chefresto'].');';
            }
                break;
            case 'camping':
            {
                $requete = $requete. 'INSERT INTO camping VALUES('.$tab['id'].');';
            }
                break;
            case 'chambre':
            {
                $requete = $requete. 'INSERT INTO chambre_hote VALUES('.$tab['id'].','.$tab['nbchambre'].','.$tab['nbcuisine'].');';
            }
                break;
        }
        $this->connexion->query($requete);
    }

    public function delete($table,$id){
        $requete ='DELETE FROM '.$table.' WHERE ID_'.$table.' = '.$id.';';
        $this->connexion->query($requete);
    }


}