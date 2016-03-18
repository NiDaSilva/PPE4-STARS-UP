<?php

class page_base {

	private $titre;
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
		return '
		<!-- Bootstrap Core CSS -->
    		<link href="css/bootstrap.min.css" rel="stylesheet">

    	<!-- Custom CSS -->
    		<link href="css/grayscale.css" rel="stylesheet">';
		}

	}
	/******************************Gestion du fonts **********************************************/

	private function fonts() {
			return'
			<link href="font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">
    		<link href="http://fonts.googleapis.com/css?family=Lora:400,700,400italic,700italic" rel="stylesheet" type="text/css">
    		<link href="http://fonts.googleapis.com/css?family=Montserrat:400,700" rel="stylesheet" type="text/css">';
		}
	}
	/******************************affichage metakeyword **********************************************/

	private function meta() {
		return'
		<meta charset="utf-8">
    	<meta http-equiv="X-UA-Compatible" content="IE=edge">
    	<meta name="viewport" content="width=device-width, initial-scale=1">
    	<meta name="description" content="">
    	<meta name="author" content="">';
	}

	/****************************** Affichage de la navbar top ***************************************/	
	private function navbar_top(){
		return'
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
	                    </li>
	                    <li>
	                        <a class="page-scroll" href="#">Connexion</a>
	                    </li>
	                    <li>
	                        <a class="page-scroll" href="#about">About</a>
	                    </li>
	                    <li>
	                        <a class="page-scroll" href="#">Contact</a>
	                    </li>
	                </ul>
	            </div>
	            <!-- /.navbar-collapse -->
	        </div>
	        <!-- /.container -->
    	</nav>';
	}


	/****************************** Affichage de la partie entÃªte ***************************************/	
	private function entete() {
		return'
		<header class="intro2">
        <div class="intro-body">
            <div class="container">
                <div class="row">
                    <div class="col-md-8 col-md-offset-2">
                        <h1 class="brand-heading2">Star\'s UP</h1>
                        <p class="intro-text">Created by 2TSIOD.</p>
                        <a href="#about" class="btn btn-circle page-scroll">
                            <i class="fa fa-angle-double-down animated"></i>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    	</header>';
	}

	/****************************** Affichage de la partie footer ***************************************/	
	private function footer() {
		return'
		<div class="container text-center">
            <p>Copyright &copy; Your Website 2014</p>
        </div>';
	}
	/****************************** Affichage de la partie sciprt ***************************************/	
	private function script() {
		return'
		    <!-- jQuery -->
		    <script src="js/jquery.js"></script>

		    <!-- Bootstrap Core JavaScript -->
		    <script src="js/bootstrap.min.js"></script>

		    <!-- Plugin JavaScript -->
		    <script src="js/jquery.easing.min.js"></script>

		    <!-- Google Maps API Key - Use your own API key to enable the map feature. More information on the Google Maps API can be found at https://developers.google.com/maps/ -->
		    <script type="text/javascript" src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCRngKslUGJTlibkQ3FkfTxj3Xss1UlZDA&sensor=false"></script>

		    <!-- Custom Theme JavaScript -->
		    <script src="js/grayscale.js"></script>';
	}


	

























	/*************************************** AFFICHER **************************************************/	
	private function afficher(){
		return'
		<!DOCTYPE html>
		<html lang="en">

		<head>
			//meta
			//titre
			//style
			//front
		</head>
		<body id="page-top" data-spy="scroll" data-target=".navbar-fixed-top">
			//navbar
			//header
			<section id="about" class="container content">
        		<div class="row">
            		<div class="col-lg-12">
            			<div class="row">
            			//corps
                		</div>         
            		</div>
            	</div>
            </section>
            <footer>
           		//footer
            </footer>
            	//script
		</body>
		';
	}

}

?>