<?php
	Include("./Class/page_base.php");
	$pageGallerie = new page_base("CVVEN-les Rousses(Jura)");
	$pageGallerie->corps ='
	<nav>
                 <ul>
                    <li><a href="index.php">Accueil</a> </li>
                    <li><a href="contact.php" >Contact</a></li>
                    <li><a href="service.php" >Services</a></li>
                    <li><a href="gallerie.php" class="current">Gallerie</a></li>
                 </ul>
              </nav>
	<div class="holder_content1">
    <section class="group4">
      <h3>Gallerie du site des Rousses</h3>
      <p></p>
     
    </section>
    
  </div>';
	$pageGallerie->afficher();
	?>
