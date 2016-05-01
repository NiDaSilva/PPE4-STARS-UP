<?php

include 'class/hebergement.controller.class.php';
$controller = new controller();
if(!isset($_GET['page']))
{
$_GET['page']=1;
}
$menu =" ";
if(isset($_SESSION['type']))
{
    switch ($_SESSION['type']) {
        case 'admin':
            {
                $menu = '<li>
                            <a class="page-scroll" href="../view/consultation_admin.php">C.R.U.D.</a>
                        </li>
                        <li>
                            <a class="page-scroll" href="../view/deconnexion.php">Deconnexion</a>
                        </li>';
            }
            break;
                case 'inspecteur':
            {
                $menu='<li>
                            <a class="page-scroll" href="../view/agenda.php">Faire son planning</a>
                        </li>
                        <li>
                            <a class="page-scroll" href="../view/deconnexion.php">Deconnexion</a>
                        </li>';
            }
            break;
                    case 'gerant':
            {
                $menu='<li>
                            <a class="page-scroll" href="../view/affichehebergement.php">Mes hebergement</a>
                        </li>

                        <li>
                            <a class="page-scroll" href="../view/demendevisite.php">Demande de visite</a>
                        </li>
                        <li>
                            <a class="page-scroll" href="../view/deconnexion.php">Deconnexion</a>
                        </li>';
            }
            break;

    }
}
else
{
    $menu='<li>
                        <a class="page-scroll" href="view/connexion.php">Connexion</a>
                    </li>
                    <li>
                        <a class="page-scroll" href="#">Contact</a>
                    </li>';
}

echo'
<style>p{height: 0px;}h4{height: 0px;margin-bottom: 60px !important;}</style>
<!DOCTYPE html>
<html lang="en">

<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Stars\'up</title>

    <!-- Bootstrap Core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom CSS -->
    <link href="css/grayscale.css" rel="stylesheet">
    <link href="owl/owl-carousel/owl.carousel.css" rel="stylesheet">
    <link href="owl/owl-carousel/owl.theme.css" rel="stylesheet">
    <link href="css/amano.css" rel="stylesheet">

    <!-- Custom Fonts -->
    <link href="font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">
    <link href="http://fonts.googleapis.com/css?family=Lora:400,700,400italic,700italic" rel="stylesheet" type="text/css">
    <link href="http://fonts.googleapis.com/css?family=Montserrat:400,700" rel="stylesheet" type="text/css">

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn\'t work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>

<body id="page-top" data-spy="scroll" data-target=".navbar-fixed-top">

    <!-- Navigation -->
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
                    </li>'.$menu.'
                    
                </ul>
            </div>
            <!-- /.navbar-collapse -->
        </div>
        <!-- /.container -->
    </nav>

    <!-- Intro Header -->
    <header class="intro">
        <div class="intro-body">
            <div class="container">
                <div class="row">
                    <div class="col-md-8 col-md-offset-2">
                        <h1 class="brand-heading">Star\'s UP</h1>
                        <p class="intro-text">Created by 2TSSIOD.</p>
                        <a href="#about" class="btn btn-circle page-scroll">
                            <i class="fa fa-angle-double-down animated"></i>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </header>

    <!-- About Section -->
    <section id="about" class="container content">
        <div class="row">
            <div class="col-lg-12">
            <!-- NAV HEBERGEMENT-->
                <nav class="navbar navbar-inverse">
                  <div class="container-fluid">
                    <!-- Brand and toggle get grouped for better mobile display -->
                    <div class="navbar-header">
                      <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                      </button>
                      <a class="navbar-brand" href="#">Brand</a>
                    </div>

                    <!-- Collect the nav links, forms, and other content for toggling -->
                    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                      <ul class="nav navbar-nav">
                        <li class="active"><a href="#">Link <span class="sr-only">(current)</span></a></li>
                        <li><a href="#">Link</a></li>
                        <li class="dropdown">
                          <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Dropdown <span class="caret"></span></a>
                          <ul class="dropdown-menu">
                            <li><a href="#">Action</a></li>
                            <li><a href="#">Another action</a></li>
                            <li><a href="#">Something else here</a></li>
                            <li role="separator" class="divider"></li>
                            <li><a href="#">Separated link</a></li>
                            <li role="separator" class="divider"></li>
                            <li><a href="#">One more separated link</a></li>
                          </ul>
                        </li>
                      </ul>
                      
                      <ul class="nav navbar-nav navbar-right">  
                             <form class="navbar-form navbar-left" role="search">
                        <div class="form-group">
                          <input type="text" class="form-control" placeholder="Search">
                        </div>
                        <button type="submit" class="btn btn-default">Submit</button>
                      </form>               
                      </ul>
                    </div><!-- /.navbar-collapse -->
                  </div><!-- /.container-fluid -->
                </nav>
                <!-- contenue -->
                <div id="row" class="row">
                <div  id="detail" class="lesdetails"></div>
                    <div class="col-lg-8 col-lg-offset-2">
                        <div class="owl-wrapper">
							'.
                          $controller->hebergement($_GET['page'])
                    .'
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>




    <!-- jQuery -->
    <script src="js/jquery.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script src="js/bootstrap.min.js"></script>

    <!-- Plugin JavaScript -->
    <script src="js/jquery.easing.min.js"></script>

    <!-- Google Maps API Key - Use your own API key to enable the map feature. More information on the Google Maps API can be found at https://developers.google.com/maps/ -->
    <script type="text/javascript" src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCRngKslUGJTlibkQ3FkfTxj3Xss1UlZDA&sensor=false"></script>

    <!-- Custom Theme JavaScript -->
    <script src="js/grayscale.js"></script>
    <script src="owl/owl-carousel/owl.carousel.min.js"></script>

</body>

</html>';
?>
<script>
    $(document).ready(function() {
        $('.owl-wrapper').owlCarousel({
            margin:10,
            loop:true,
            autoWidth:true,
            items:3
        });
        $(".owl-controls").remove();
    });
</script>