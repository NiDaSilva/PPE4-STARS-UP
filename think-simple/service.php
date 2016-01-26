<?php
	Include("./Class/page_base.php");
	$pageService = new page_base("CVVEN-les Rousses(Jura)");
	$pageService->corps ='
			 <nav>
                 <ul>
                    <li><a href="index.php">Accueil</a> </li>
                    <li><a href="contact.php" >Contact</a></li>
                    <li><a href="service.php" class="current">Services</a></li>
                    <li><a href="gallerie.php">Gallerie</a></li>
                 </ul>
              </nav>
	<div class="holder_content1">
    <section class="group4">
      <h3>Service du site des Rousses</h3>
      <p></p>
     
    </section>
    
  </div>';
	$pageService->afficher();
	?>
