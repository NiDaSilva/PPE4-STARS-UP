<?php
include 'mypdo.class.php';
class controller{

    private $vpdo;
    private $db;
    public function __construct() {
        $this->vpdo = new mypdo ();
        //$this->db = $this->vpdo->connexion;
    }
    public function __get($propriete) {
        switch ($propriete) {
            case 'vpdo' :
            {
                return $this->vpdo;
                break;
            }
            case 'db' :
            {

                return $this->db;
                break;
            }
        }
    }
        
    

    public function hebergement($x)
    {
        $retour='<div class="owl-item"><div class="col-sm-6 col-md-4">';
        $result= $this->vpdo->return_table('hebergement',$x,0);
        $i=0;
        while ($row =$result->fetch())
        {
            if ($i % 2 == 0 && $i !=0) {
                $retour = $retour . '</div>
                                </div>
                                <div class="owl-item">
                                    <div class="col-sm-6 col-md-4">';
            }
            $retour = $retour . '
                <div class="thumbnail" style="width:204px;height: 362px;">
                    <img src="http://placehold.it/350x150" alt="320x150">
                    <div class="caption">
                        <h4><a href="#">' . $row['NOM_HEBERGEMENT'] . '</a></h4>
                        <p>' . $row['ADRESSE_HEBERGEMENT'] . '</p>
                        <p><a href="#" class="btn btn-primary" role="button">Button</a> <a href="#" class="btn btn-default" role="button">Button</a></p>
                    </div>
                </div>
            ';
            $i++;
        }
        return $retour;
    }

}
?>