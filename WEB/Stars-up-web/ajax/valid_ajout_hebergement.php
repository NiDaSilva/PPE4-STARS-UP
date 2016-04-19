<?php


include_once('../class/mypdo.class.php');
$vpdo=new mypdo();
$tab=array();
//test validation frd champ a faire.
if($_REQUEST['departement']!= 0){
$tab['departement']=intval($_REQUEST['departement']);
$tab['gerant']=intval($_REQUEST['gerant']);
$tab['nom']=$_REQUEST['nom'];

$tab['adresse']=$_REQUEST['adresse'];
$tab['ville']=$_REQUEST['ville'];
$tab['horaire']=$_REQUEST['horaire'];
/********* la boucle sale ! **********/
$result = $vpdo->return_table('hebergement',0,0);
while ($row = $result->fetch()) {
	$tab['id']=$row['ID_HEBERGEMENT']+1;
}
/************************************/

	if(isset($_REQUEST['table']))
	{
		$tab['table']=intval($_REQUEST['table']);
		$tab['alert']='
			<div class="alert alert-success alert-dismissible" role="alert">
					<button type="button" class="close" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">&times;</span></button>
					 l\'hebergement '.$tab['nom'].' Ajouté !
			</div>
			';
		switch ($tab['table']) {
			case 1: //hotel
			{
				$tab['nbresto']=intval($_REQUEST['nbresto']);
				$tab['chefresto']=$_REQUEST['chefresto'];
			}
				break;
			case 2: //camping
			{

			}
				break;
			case 3: //chambre d'hote
			{
				$tab['nbchambre']=intval($_REQUEST['nbchambre']);
				$tab['nbcuisine']=intval($_REQUEST['nbcuisine']);
			}
				break;
		}
	}
	$vpdo->insert_hebergement($tab);


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