<?php

class mypdo extends PDO
{
    private $PARAM_hote ='localhost'; //'192.168.215.10'; // le chemin vers le serveur : 192.168.215.10
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

        $requ = $this->connexion->prepare('SELECT * FROM '.$tab["type"].' WHERE LOGIN="'.$tab["login"].'" and MDP="'.$tab["pass"].'";');
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

    public function update($tab){
        switch ($tab['table']) {
            case 'visiter':
            {
                $requete = 'UPDATE visiter SET ID_INSPECTEUR='.$tab['id'].', DATE_HEURE_VISITE="'.$tab['date'].'" WHERE ID_VISITE='.$tab['idv'].';';
            }
                break;
//            case 'camping':
//            {
//                $requete ='INSERT INTO camping VALUES('.$tab['id'].');';
//            }
//                break;
//            case 'chambre':
//            {
//                $requete ='INSERT INTO chambre_hote VALUES('.$tab['id'].','.$tab['nbchambre'].','.$tab['nbcuisine'].');';
//            }
//                break;
        }
        $this->connexion->query($requete);
    }



    public function inscription($tab){

        try
        {
            $this->connexion->beginTransaction();
            $requete ='INSERT INTO gerant (NOM_GERANT,PRENOM_GERANT, LOGIN, MDP) VALUES("'.$tab['nom'].'","'.$tab['prenom'].'","'.$tab['login'].'","'.$tab['pass'].'");';
            $this->connexion->exec($requete);
            $this->connexion->commit();
            return true;
        }
        catch (PDOException $e)
        {
            if ($this->connexion) $this->connexion->rollBack();
            return false;

        }
    }



    public function get_visites($id)
    {
        $requete=$this->connexion->prepare('select v.ID_VISITE as "IDV", v.ID_HEBERGEMENT as "ID", h.NOM_HEBERGEMENT as "NOM", h.ADRESSE_HEBERGEMENT as "ADRESSE", h.VILLE_HEBERGEMENT as "VILLE", v.DATE_HEURE_VISITE as "DATE", h.HORAIRES, v.COMMENTAIRE_VISITE from visiter as v inner join hebergement as h on v.ID_HEBERGEMENT = h.ID_HEBERGEMENT where id_inspecteur ='.$id.';');
        $requete->execute();
        $result = $requete->fetchAll(PDO::FETCH_ASSOC);
        if($result)
        {
            return ($result);
        }
        return null;
    }

    public function get_demandes($id)
    {
        $requete=$this->connexion->prepare('SELECT v.ID_VISITE as "IDV", h.NOM_HEBERGEMENT as "NOM", h.ADRESSE_HEBERGEMENT as "ADRESSE", h.VILLE_HEBERGEMENT as "VILLE", h.HORAIRES as "HORAIRES" FROM visiter as v INNER JOIN hebergement as h on v.ID_HEBERGEMENT = h.ID_HEBERGEMENT INNER join correspondre as c on h.ID_HEBERGEMENT = c.ID_HEBERGEMENT WHERE v.ID_INSPECTEUR is null AND v.DATE_HEURE_VISITE is null AND c.ID_SPECIALITE = (Select i.ID_SPECIALITE FROM inspecteur as i WHERE i.ID_INSPECTEUR ='.$id.');');
        $requete->execute();
        $result = $requete->fetchAll(PDO::FETCH_ASSOC);
        if($result)
        {
            return ($result);
        }
        return null;
    }

    public function delete($table,$id){
        $requete ='DELETE FROM '.$table.' WHERE ID_'.$table.' = '.$id.';';
        $this->connexion->query($requete);
    }


}