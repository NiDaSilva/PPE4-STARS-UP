<?php
include_once('../class/page_base.class.php');
class page_base_gerant extends page_base {

	public function __construct($p) {
		parent::__construct($p);
	}
	public function affiche() {
		
		parent::afficher();
		
	}
	public function navbar(){return'
						<li>
	                        <a class="page-scroll" href="../view/affichehebergement.php">Mes hebergement</a>
	                    </li>

	                    <li>
	                        <a class="page-scroll" href="../view/demendevisite.php">Demande de visite</a>
	                    </li>
	                    <li>
	                        <a class="page-scroll" href="../view/deconnexion.php">Deconnexion</a>
	                    </li>';
					
	


	}
}
