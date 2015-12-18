<?php
class page_base{
	private $titre;
	private $corps;
	private $style = array('css3','styles');
	
	
	public function __construct($p){
		$this->titre = $p;
	}
	public function __set($propriete, $valeur){
		switch ($propriete) {
			case 'corps' : {
				$this->corps = $valeur;
				break;
			}
			case 'titre' : {
				$this->titre = $valeur;
				break;
			}
			case 'style' : {
                $this->style[count($this->style)+1] = $valeur;
                break;
}
		}
	}
	/****Gestion des styles : Insertion des feuilles de style *************/
         private function affiche_style() {
          foreach ($this->style as $s) {
     /*attention aux double quotes et aux simples quotes*/
         echo "<link rel='stylesheet' type='text/css' href='Style/".$s.".css'/>\n";
}
}
        private function affiche_entete() {
			?>
			<header>
			<a href="#" id="logo"><img src="images/logo-jura.jpg" width="221" height="100" alt=""></a>
			</header>
			<?php
		}
		private function affiche_menu() { ?>
			 <nav>
                 <ul>
                    <li><a href="index.php">Accueil</a> </li>
                    <li><a href="contact.php" >Contact</a></li>
                    <li><a href="service.php">Services</a></li>
                    <li><a href="gallerie.php">Gallerie</a></li>
                 </ul>
              </nav>
			<?php
		}
		private function affiche_footer() { ?>
			<footer>
                <div class="container">
                <div id="FooterTwo"> &copy; 2015 site du Jura </div>
                <div id="FooterTree">Website du site du Jura / <a target="_blank" href="http://www.jura-tourism.com/">office du tourisme</a></div>
                </div>
            </footer>
			<?php
		}
		
		
	
	public function afficher(){
		?>
		<!DOCTYPE html>
		<html lang='fr'>
		<head>
		<meta http-equiv="Content-Type" content="text/html;charset=UTF-8" />
		<meta name="keywords" lang="fr" content="BTS,SIO,informatique,etude,technicien" />
        <meta name="description" content="Description du BTS Services Informatiques aux Organisations (S.I.O)." />
        <?php $this->affiche_style();?>
        <title> <?php echo $this->titre;?> </title>
        </head>
        <body>
        <div id="global">
        <?php $this->affiche_entete(); ?>
          <div id="centre">
                <div id="navigation">
               <?php $this->affiche_menu(); ?>
        </div>
             <div id="contenu">
                   <?php echo $this->corps;?>
                   <?php $this->affiche_footer();?>
             </div>
          </div>
       </div>
       </body>
       </html>
       <?php /*on ré-ouvre le php pour les 2 accolades */
}
}
?>

