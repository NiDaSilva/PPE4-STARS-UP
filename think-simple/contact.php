<?php
	Include("./Class/page_base.php");
	$pageContact = new page_base("CVVEN-les Rousses(Jura)");
	$pageContact->corps ='
			 <nav>
                 <ul>
                    <li><a href="index.php">Accueil</a> </li>
                    <li><a href="contact.php" class ="current">Contact</a></li>
					<li><a href="service.php">Services</a></li>
                    <li><a href="gallerie.php">Gallerie</a></li>
                 </ul>
              </nav>
			  
	<div class="holder_content1">
    <section class="group4">
      <h3>Contact du site des Rousses</h3>
	  
			 
		<article>
			<form action="tt_envoyer.php" method="GET" >
<fieldset>
	<legend>formulaire de contact</legend>
	<br/>
	Nom : &nbsp;<input type="text" name="nom" id="nom"size="40" maxlength="50" autofocus required onblur="verifZonedeTexte()"><br/><br/>
	Pr&eacute;nom : <input type="text" name="prenom" id="prenom" size="40" maxlength="50" required><br/><br/>
	Email : <input type="email" name="mail" required placeholder="Votre adresse mail !"><br/><br/>
	Numero de telephone : <input type="tel" name="tel" required ><br/><br/>
	<br/>


	
	<label for="mess">Votre message : <label/>
	<textarea name="mess" id="mess"required rows="4" cols="50"></textarea><br/><br/>
	

	<input type="submit" value="Valider">
	<input type="reset" value="Recommencer" ">
</form>



		</article>				
	
     
    </section>
    
  </div>';
	$pageContact->afficher();
	?>


