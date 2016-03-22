<?php
include 'mypdo.class.php';
class con_controller{

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

    public function corps_connexion()
    {
        $r= '
            <div class="panel panel-default">
                <div class="panel-heading">
                    <h3 class="panel-title">Selectionner une table</h3>
                </div>  
                <div class="panel-body">
                <form id=select method="post">
                    <select id="nomtable" name="nomtable" class="form-control" onChange="document.getElementById(\'select\').submit()"> 
                    <option value="" disabled selected>Select your option</option>                  
                    <option value ="hebergement">Hebergement</option>
                    <option value="inspecteur">Inspecteur</option>
                    </select>
                </form>
                </div>  
            </div>'
       ;
       return $r;
    }

}
?>