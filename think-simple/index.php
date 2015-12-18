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
    
    <!--end logo-->
    <!--start menu-->
    <nav>
      <ul>
        <li><a href="index.php" class="current">Accueil</a> </li>
        <li><a href="contact.php">Contact</a></li>
        <li><a href="service.php">Services</a></li>
        <li><a href="gallerie.php">Gallerie</a></li>
      </ul>
    </nav>
    <!--end menu-->
    <!--end header-->
  </header>
  <!--start annner_lintro-->
  <div id="intro">
    
    <header class="groupe1">
      <hgroup>
        <h1>Stars'UP</h1>
        <h2>trouver une phrase sympa</h2>
      </hgroup>
    </header>
  </div>
  <!--end intro-->
  <!--start holder-->
  <div class="holder_content">
    <section class="group1">
      <h3>A propos</h3>
      <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec molestie. Sed aliquam sem ut arcu. Phasellus sollicitudin. Vestibulum condimentum facilisis nulla. In hac habitasse platea dictumst. Nulla nonummy. Cras quis libero.</p>
      </section>
    <section class="group2">
      <h3>Services</h3>
      <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec molestie. Sed aliquam sem ut arcu. Phasellus sollicitudin. Vestibulum condimentum facilisis nulla. In hac habitasse platea dictumst. Nulla nonummy. Cras quis libero.</p>
      </section>
    <section class="group3">
      <h3>Description du Jura</h3>
      <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec molestie. Sed aliquam sem ut arcu. Phasellus sollicitudin. Vestibulum condimentum facilisis nulla. In hac habitasse platea dictumst. Nulla nonummy. Cras quis libero.</p>
      </section>
  </div>
  <!--end holder-->
  <!--start holder-->
  <div class="holder_content1">
    <section class="group4">
      <h3>Gallerie</h3>
      <p>Les plus belles images du Jura à toute saisons à tout moment de la journée</p>
      <div class="pikachoose">
        <ul id="pikame" >
          <li><a href="#"><img src="images/juraN.jpg" width="500" height="250" alt=""></a><span>“c'est très très jolie la nuit, c'est pas mal, il faut allé voir !”</span></li>
          <li><a href="#"><img src="images/Jura.jpg" width="500" height="250" alt=""></a><span>“Paysage fabuleux a voir tôt le matin en été“ </span></li>
          <li><a href="#"><img src="images/juraNeige.jpg" width="500" height="250" alt=""></a><span>“En journée, lorsque le soleil donne.”</span></li>
        </ul>
      </div>
    </section>
    <section class="group5">
      <h3>Testimonials</h3>
      <p><span class="purple">1)</span>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec molestie. Sed aliquam sem ut arcu. Phasellus sollicitudin. Vestibulum condimentum facilisis nulla. In hac habitasse platea dictumst. Nulla nonummy. Cras quis libero.</p>
      <p><span class="purple">2)</span>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec molestie. Sed aliquam sem ut arcu. Phasellus sollicitudin. Vestibulum condimentum facilisis nulla. In hac habitasse platea dictumst. Nulla nonummy. Cras quis libero.</p>
      <p><span class="purple">3)</span>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec molestie. Sed aliquam sem ut arcu. Phasellus sollicitudin. Vestibulum condimentum facilisis nulla. In hac habitasse platea dictumst. Nulla nonummy. Cras quis libero.</p>
    </section>
  </div>
  <!--end holder-->
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
