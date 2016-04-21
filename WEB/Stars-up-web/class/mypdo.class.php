<?php

class mypdo extends PDO
{
    private $PARAM_hote ='localhost'; // le chemin vers le serveur : 192.168.215.10
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


    public function update($tab){
        switch ($tab['table']) {
            case 'visiter':
            {
                $requete = 'UPDATE visite SET ID_INSPECTEUR='.$tab['id'].', DATE_HEURE_VISITE="'.$tab['date'].'" WHERE ID_VISITE='.$tab['idv'].';';
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
        $requete=$this->connexion->prepare('select v.ID_VISITE as "IDV", v.ID_HEBERGEMENT as "ID", h.NOM_HEBERGEMENT as "NOM", h.ADRESSE_HEBERGEMENT as "ADRESSE", h.VILLE_HEBERGEMENT as "VILLE", v.DATE_HEURE_VISITE as "DATE", h.HORAIRES, v.COMMENTAIRE_VISITE from visite as v inner join hebergement as h on v.ID_HEBERGEMENT = h.ID_HEBERGEMENT where id_inspecteur ='.$id.';');
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
        $requete=$this->connexion->prepare('SELECT v.ID_VISITE as "IDV", h.NOM_HEBERGEMENT as "NOM", h.ADRESSE_HEBERGEMENT as "ADRESSE", h.VILLE_HEBERGEMENT as "VILLE", h.HORAIRES as "HORAIRES" FROM visite as v INNER JOIN hebergement as h on v.ID_HEBERGEMENT = h.ID_HEBERGEMENT WHERE v.ID_INSPECTEUR is null AND v.DATE_HEURE_VISITE is null AND h.ID_SPECIALITE = (Select i.ID_SPECIALITE FROM inspecteur as i WHERE i.ID_INSPECTEUR ='.$id.');');
        $requete->execute();
        $result = $requete->fetchAll(PDO::FETCH_ASSOC);
        if($result)
        {
            return ($result);
        }
        return null;
    }
















///**********************************************************C.R.U.D ADMIM*************************************************************///


/*********************CREATE*******************************/

    public function insert_hebergement($tab){
        $requete = 'INSERT INTO hebergement (ID_HEBERGEMENT,ID_DEPARTEMENT,ID_GERANT, NOM_HEBERGEMENT,ADRESSE_HEBERGEMENT,VILLE_HEBERGEMENT, HORAIRES, ID_SPECIALITE)
        VALUES('.$tab['id'].','.$tab['departement'].','.$tab['gerant'].',"'.$tab['nom'].'","'.$tab['adresse'].'","'.$tab['ville'].'","'.$tab['horaire'].'",'.$tab['table'].'); ';
        switch ($tab['table']) {
            case 1:
            {
                $requete = $requete. 'INSERT INTO hotel VALUES('.$tab['id'].','.$tab['nbresto'].',"'.$tab['chefresto'].'");';
            }
                break;
            case 2:
            {
                $requete = $requete. 'INSERT INTO camping VALUES('.$tab['id'].');';
            }
                break;
            case 3:
            {
                $requete = $requete. 'INSERT INTO chambre_hote VALUES('.$tab['id'].','.$tab['nbchambre'].','.$tab['nbcuisine'].');';
            }
                break;
        }
        $this->connexion->query($requete);
    }
    public function insert_inspecteur($tab)
    {
        $requete = 'INSERT INTO inspecteur (ID_SPECIALITE, NOM_INSPECTEUR, PERNOM_INSPECTEUR, LOGIN, MDP) VALUES ('.$tab['specialite'].',"'.$tab['nom'].'","'.$tab['prenom'].'","'.$tab['login'].'","'.$tab['password'].'"); ';
        $this->connexion->query($requete);
    }
    public function insert_gerant($tab)
    {
        $requete ='INSERT INTO gerant (NOM_GERANT,PRENOM_GERANT, LOGIN, MDP) VALUES("'.$tab['nom'].'","'.$tab['prenom'].'","'.$tab['login'].'","'.$tab['password'].'");';
        $this->connexion->query($requete);
    }
    public function insert_visite($tab)
    {
        $requete = 'INSERT INTO saison (LIBELLE_SAISON) VALUES ("'.$tab['saison'].' '.$tab['annee'].'")';
        $this->connexion->query($requete);
        $requete2 ='SELECT * FROM saison WHERE LIBELLE_SAISON = "'.$tab['saison'].' '.$tab['annee'].'";';
        $id_saison=null;
        $result = $this->connexion->query($requete2);
        while ($row =$result->fetch())
            {
                $id_saison = $row['ID_SAISON'];
            }
        $requete3 = 'INSERT INTO visite (ID_HEBERGEMENT,ID_SAISON) VALUES ('.$tab['hebergement'].','.intval($id_saison).');';
        $this->connexion->query($requete3);

    }
/************************READ***********************************/
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
    public function get_item($table, $id)
    {
        $requete = 'SELECT * FROM '.$table.' WHERE id_'.$table.' = '.$id.' ;';
        $result = $this->connexion->query($requete);
        return $result;
    }
/************************UPDATE*************************************/
    public function update_hebergement($tab)
    {
        
    }
    public function update_inspecteur($tab)
    {
        $requete = 'UPDATE inspecteur SET ID_SPECIALITE='.$tab['specialite'].' , NOM_INSPECTEUR ="'.$tab['nom'].'" , PERNOM_INSPECTEUR="'.$tab['prenom'].'" , LOGIN="'.$tab['login'].'" , MDP="'.$tab['password'].'" WHERE ID_INSPECTEUR = '.$tab['id'].'; ';
        $this->connexion->query($requete);
    }
    public function update_gerant($tab)
    {
        $requete = 'UPDATE gerant SET NOM_GERANT ="'.$tab['nom'].'" , PRENOM_GERANT="'.$tab['prenom'].'" , LOGIN="'.$tab['login'].'" , MDP="'.$tab['password'].'" WHERE ID_GERANT = '.$tab['id'].'; ';
        $this->connexion->query($requete);
    }
    public function update_visite($tab)
    {
        $requete = 'INSERT INTO saison (LIBELLE_SAISON) VALUES ("'.$tab['saison'].' '.$tab['annee'].'")';
        $this->connexion->query($requete);
        $requete2 ='SELECT * FROM saison WHERE LIBELLE_SAISON = "'.$tab['saison'].' '.$tab['annee'].'";';
        $id_saison=null;
        $result = $this->connexion->query($requete2);
        while ($row =$result->fetch())
            {
                $id_saison = $row['ID_SAISON'];
            }
        $requete3 = 'UPDATE visite SET ID_HEBERGEMENT = '.$tab['hebergement'].' , ID_SAISON = '.intval($id_saison).' , ID_INSPECTEUR = '.$tab['inspecteur'].' , NOMBRE_ETOILE_VISITE = '.$tab['etoile'].', DATE_HEURE_VISITE = "'.$tab['date'].'" , COMMENTAIRE_VISITE = "'.$tab['commentaire'].'" , ID_CONTREVISITE = '.$tab['id_contrevisite'].' WHERE id_visite = '.$tab['id'].';';

            $this->connexion->query($requete3);        
    }
/**************************DELETE**********************************/
    public function delete($table,$id){
        $requete ='DELETE FROM '.$table.' WHERE ID_'.$table.' = '.$id.';';
        $this->connexion->query($requete);
    }
}