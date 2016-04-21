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
        $retour='';
        $result= $this->vpdo->return_table('hebergement',$x,6);
        while ($row =$result->fetch())
        {
            $retour = $retour . '
            <div class="owl-item">
            <div class="col-sm-6 col-md-4">
                <div id="' . $row['ID_HEBERGEMENT'] . '" class="thumbnail hotel">
                    <img src="http://placehold.it/350x150" alt="320x150">
                    <div class="caption">
                        <h4><a href="#">' . $row['NOM_HEBERGEMENT'] . '</a></h4>
                        <p>' . $row['ADRESSE_HEBERGEMENT'] . '</p>
                        <p><a href="#" class="btn btn-primary" role="button">Button</a> <a href="#" class="btn btn-default" role="button">Button</a></p>
                    </div>
                </div>
            </div>
            </div>';
        }
        $retour = $retour . '<div id="details" class="lesdetails" style="background-color:white; width:465px;height:515px; display:none;"></div>';
        return $retour;
    }
    public function pagination($perPage)
    {
        $nbRow= $this->vpdo->count_row('hebergement');
        $nbpage= ceil($nbRow/$perPage);
        $retour = '
        <div>
        <nav>
          <ul class="pagination">
            <li>
              <a href="#" aria-label="Previous">
                <span aria-hidden="true">&laquo;</span>
              </a>
            </li>';
            for ($i=1; $i <= $nbpage ; $i++) {
               $retour= $retour.'<li><a href="?page='.$i.'&#about">'.$i.'</a></li>';
            }
        $retour= $retour.'
            <li>
              <a href="#" aria-label="Next">
                <span aria-hidden="true">&raquo;</span>
              </a>
            </li>
          </ul>
        </nav>
        </div>';
        return $retour;
    }
}
?>