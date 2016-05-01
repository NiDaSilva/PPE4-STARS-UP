<?php

class page_base {

	protected $titre;
	protected $corps;

	public function __construct($p) {
				$this->titre = $p;
	}
	public function __set($propriete, $valeur) {
		switch ($propriete) 
		{
			case 'corps' : {
				$this->corps = $valeur;
				break;
			}

			case 'titre' : {
				$this->titre = $valeur;
				break;
			}
		}
	}

	/******************************Gestion des styles **********************************************/
	private function style() {
		$r= '
    		<link href="../css/bootstrap.min.css" rel="stylesheet">
    		<link href="../css/grayscale.css" rel="stylesheet">';
		echo $r;

	}
	/******************************Gestion du fonts **********************************************/

	private function fonts() {
			$r= '
			<link href="../font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">
    		<link href="http://fonts.googleapis.com/css?family=Lora:400,700,400italic,700italic" rel="stylesheet" type="text/css">
    		<link href="http://fonts.googleapis.com/css?family=Montserrat:400,700" rel="stylesheet" type="text/css">';
    		echo $r;
		
	}
	/******************************affichage metakeyword **********************************************/

	private function meta() {
		$r='
		<meta charset="utf-8">
    	<meta http-equiv="X-UA-Compatible" content="IE=edge">
    	<meta name="viewport" content="width=device-width, initial-scale=1">
    	<meta name="description" content="">
    	<meta name="author" content="">';
    	echo $r;
	}

	/****************************** Affichage de la navbar top ***************************************/
	protected function navbar()
	{
		$r='	         <li>
                        <a class="page-scroll" href="view/connexion.php">Connexion</a>
                    </li>
                    <li>
                        <a class="page-scroll" href="#">Contact</a>
                    </li>';
	    return $r;
	}	
	private function navbar_top(){
		$r='
		<nav class="navbar navbar-custom navbar-fixed-top" role="navigation">
	        <div class="container">
	            <div class="navbar-header">
	                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-main-collapse">
	                    <i class="fa fa-bars"></i>
	                </button>
	                <a class="navbar-brand page-scroll" href="#page-top">
	                    <i class="fa fa-play-circle"></i>  <span class="light">Star\'s</span> UP
	                </a>
	            </div>

	            <!-- Collect the nav links, forms, and other content for toggling -->
	            <div class="collapse navbar-collapse navbar-right navbar-main-collapse">
	                <ul class="nav navbar-nav">
	                    <!-- Hidden li included to remove active class from about link when scrolled up past about section -->
	                    <li class="hidden">
	                        <a href="#page-top"></a>
	                    </li>'.$this->navbar().'

	                </ul>
	            </div>
	            <!-- /.navbar-collapse -->
	        </div>
	        <!-- /.container -->
    	</nav>';
    	echo $r;
	}


	/****************************** Affichage de la partie entÃªte ***************************************/	
	private function entete() {
		$r='
		<header class="intro2">
        <div class="intro-body">
            <div class="container">
                <div class="row">
                    <div class="col-md-8 col-md-offset-2">
                        <h1 class="brand-heading2">'.$this->titre.'</h1>                       
                    </div>
                </div>
            </div>
        </div>
    	</header>';
    	echo $r;
	}

	/****************************** Affichage de la partie footer ***************************************/	
	private function footer() {
		$r='
		<footer>
		<div class="container text-center">
            <p>Copyright &copy; Your Website 2014</p>
        </div>
        </footer>';
        echo $r;
	}
	/****************************** Affichage de la partie script ***************************************/
	private function script() {
		$r='
  <header>
            <link rel="stylesheet" href="../fullcalendar/fullcalendar.css" />
            <link rel="stylesheet" href="../css/amano.css" />
            <link rel="stylesheet" href="../jquery-ui/jquery-ui.theme.min.css" />
            <link rel="stylesheet" href="../jquery-ui/jquery-ui.structure.min.css" />
            <!-- jQuery -->
		    <script src="../js/jquery.js"></script>
		    <!-- Bootstrap Core JavaScript -->
		    <script src="../js/bootstrap.min.js"></script>

		    <!-- Plugin JavaScript -->
		    <script src="../js/jquery.easing.min.js"></script>

		    <!-- Custom Theme JavaScript -->
		    <script src="../js/grayscale.js"></script>
            <script src="../fullcalendar/lib/moment.min.js"></script>
            <script src="../fullcalendar/fullcalendar.js"></script>
            <script src="../class/agenda.js"></script>
            <script src="../fullcalendar/lib/jquery-ui.custom.min.js"></script>
            <script src="../jquery-ui/jquery-ui.min.js"></script>
            <script src="../fullcalendar/fullcalendar.js"></script>
            <script src="../fullcalendar/lang-all.js"></script>
        </header>';
		    echo $r;
	}
	private function head(){
		echo'
		<head>'
		.$this->meta()
		.'<title>'.$this->titre.'</title>'
		.$this->style()
		.$this->fonts()
		.'</head>';
	}
	private function content(){
		echo'<section id="about" class="container content">
				<div class="row">
	        		<div class="col-lg-12">
	        			<div class="row">
	                    	<div class="col-lg-8 col-lg-offset-2">
	        					'.$this->corps.'
	        				</div>
	        			</div>
	        		</div>
	            </div>
            </section>';
	}
	/*************************************** AFFICHER **************************************************/	

	public function afficher(){
		echo'
		<html lang="en">'
		.$this->head().'		
		<body id="page-top" data-spy="scroll" data-target=".navbar-fixed-top">'
		.$this->navbar_top()
		.$this->entete()
		.$this->content()
        .$this->script()
		.'</body>'
		.$this->footer().'
		</html>
		';
	}
}

?>