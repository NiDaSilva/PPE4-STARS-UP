<!DOCTYPE html>
<html lang="en" dir="ltr">
<head>
<title>CVVEN-les Rousses(Jura)</title>
<meta charset="UTF-8">
<!--[if lt IE 9]><script src="js/html5.js"></script><![endif]-->
<link rel="stylesheet" type="text/css" href="./Style/styles.css">
<link type="text/css" href="./Style/css3.css" rel="stylesheet">
<script src="js/jquery-1.6.min.js"></script>
<script src="js/jquery.pikachoose.js"></script>
<script>
$(document).ready(
function () {
    $("#pikame").PikaChoose();
});
</script>
</head>
<body>
<!--start container-->
<div id="container">
  <!--start header-->
  <header>
    <!--start logo-->
    <a href="#" id="logo"><img src="images/logo-jura.jpg" width="221" height="100" alt=""></a>
    <!--end logo-->
    <!--start menu-->
    <nav>
      <ul>
        <li><a href="index.php">Accueil</a> </li>
        <li><a href="contact.php"  class="current">Contact</a></li>
        <li><a href="service.php">Services</a></li>
        <li><a href="gallerie.php">Gallerie</a></li>
      </ul>
    </nav>
    <!--end menu-->
    <!--end header-->
  </header>
  <!--debut traitement formulaire-->
  
  <?php 
  
			if (isset($_GET['nom']) && isset($_GET['prenom'])) {
				echo ("<h2>". $_GET['prenom']."  <strong>".$_GET['nom']."  </strong> : ");
				?>
				<br><br>
				
				
				<?php
				if (isset($_GET['mess']) ){
					echo (" Votre n° de telephone : ".$_GET['tel']);}
				
				?>
				
				<br><br>
				
				<?php
				if (isset($_GET['mail']) ){
					echo (" Votre adresse Email : ".$_GET['mail']);}
					?>
                <br><br>
				
				
				<table border="1">
				<tr>
				<th > Votre message </th>
				</tr>
				
				<tr>
				<td><?php echo($_GET['mess']); ?></td>
				</tr>
				</table><br>
				
				<?php
			}
			else {
				echo ('<h3> vous devez remplir le formulaire au préalable sur la page <a href="choisir_specialite.php">formulaire à remplir pour choisir votre spécialité</a></h3>');
			}
					
			?>
  <!--fin traitement formulaire-->
  
</div>
<!--end container-->
<!--start footer-->
<footer>
  <div class="container">
    <div id="FooterTwo"> &copy; 2015 site du Jura </div>
    <div id="FooterTree">Website du site du Jura / <a target="_blank" href="http://www.jura-tourism.com/">office du tourisme</a></div>
  </div>
</footer>
<!--end footer-->
</body>
</html>