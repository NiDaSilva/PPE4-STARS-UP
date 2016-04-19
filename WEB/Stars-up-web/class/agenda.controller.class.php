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
      <div class="row">
        <div id="calendar"></div>
        <div id="external-events">
			<h4>Les demandes</h4>
		</div>
      </div>
      <div id="trash">trash</div>?';
        return $r;
    }

}
?>