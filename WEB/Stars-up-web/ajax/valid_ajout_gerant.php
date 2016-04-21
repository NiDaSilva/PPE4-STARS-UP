<?php


include_once('../class/mypdo.class.php');
$vpdo=new mypdo();
$tab=array();

//test validation frd champ a faire.
		if($_REQUEST['nom']!=null)
		{
			$tab['nom']=$_REQUEST['nom'];
			$tab['prenom']=$_REQUEST['prenom'];
			$tab['login']=$_REQUEST['login'];
			$tab['password']=$_REQUEST['password'];
			$tab['alert']='
				<div class="alert alert-success alert-dismissible" role="alert">
						<button type="button" class="close" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">&times;</span></button>
						'.$_REQUEST['table'].' '.$tab['nom'].' Ajouté !
				</div>
				';
			$vpdo->insert_gerant($tab);
		}
		else
		{
			$tab['alert']='
					<div class="alert alert-danger alert-dismissible" role="alert">
							<button type="button" class="close" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">&times;</span></button>
							Tous les champs ne sont pas remplis FDP !
					</div>
					';
		}		

echo json_encode($tab['alert']);
?>