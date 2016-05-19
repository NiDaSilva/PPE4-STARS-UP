<?php
include 'mypdo.class.php';
class agen_controller{

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

    public function corps_agenda()
    {
        $r= '
    <div class="row agenda">
        <div class="col-xs-4">
            <div id="external-events">
			    <h4 style="margin-top: 5px">Les demandes</h4>
		    </div>
		</div>
        <div class="col-xs-8">
            <div id="calendar"></div>
        </div>
    </div>?';
        return $r;
    }

}
?>