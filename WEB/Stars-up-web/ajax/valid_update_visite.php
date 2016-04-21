<?php


include_once('../class/mypdo.class.php');
$vpdo=new mypdo();
$tab=array();
//test validation frd champ a faire.
		if($_REQUEST['hebergement']!= 0)
		{
			$tab['hebergement']=intval($_REQUEST['hebergement']);
			$tab['saison']=$_REQUEST['saison'];
			$tab['annee']=$_REQUEST['annee'];
			
			$tab['alert']='
				<div class="alert alert-success alert-dismissible" role="alert">
						<button type="button" class="close" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">&times;</span></button>
						'.$_REQUEST['table'].' Modifier !
				</div>
				';
			$vpdo->update_visite($tab);
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
