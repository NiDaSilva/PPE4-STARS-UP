<?php


include_once('../class/mypdo.class.php');
$vpdo=new mypdo();
$tab=array();

if($_REQUEST['departement']!= 0){
$tab['departement']=intval($_REQUEST['departement']);
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
		$tab['table']=$_REQUEST['table'];
		$tab['alert']='
			<div class="alert alert-success alert-dismissible" role="alert">
					<button type="button" class="close" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">&times;</span></button>
					'.$_REQUEST['table'].' Ajouté !
			</div>
			';
		switch ($_REQUEST['table']) {
			case 'hotel':
			{
				$tab['nbresto']=intval($_REQUEST['nbresto']);
				$tab['chefresto']=$_REQUEST['chefresto'];
			}
				break;
			case 'camping':
			{

			}
				break;
			case 'chambre':
			{
				$tab['nbchambre']=intval($_REQUEST['nbchambre']);
				$tab['nbcuisine']=intval($_REQUEST['nbcuisine']);
			}
				break;
		}
	}
	$vpdo->insert($tab);

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

//$vpdo->insert($tab)

echo json_encode($tab['alert']);
?>