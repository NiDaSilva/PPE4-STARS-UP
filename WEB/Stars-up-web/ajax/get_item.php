<?php
//envoi du formulaire hebergement.

include_once('../class/mypdo.class.php');
$vpdo=new mypdo();
$item =array();
if(isset($_REQUEST['table']) && isset($_REQUEST['id']))
{
	$id = intval($_REQUEST['id']);
	$table = $_REQUEST['table'];
	$result = $vpdo->get_item($table, $id);
	if($result)
	{
		switch ($table) 
		{

			case 'hebergement':
			{
					$r =$result->fetch();
			 	    $item=array(
				        "id" => $r["ID_HEBERGEMENT"],
				        "ID_SPECIALITE" => $r["ID_DEPARTEMENT"],
				        "id_gerant" => $r["ID_GERANT"],
				        "nom" => $r["NOM_HEBERGEMENT"],
				        "adresse" => $r["ADRESSE_HEBERGEMENT"],
				        "ville" => $r["VILLE_HEBERGEMENT"],
				        "horaires" => $r["Horaires"],

				        "specialite"  => $r["ID_SPECIALITE"]
				    );
			}
				break;
			case 'inspecteur':
			{
				//print_r("enfin");
				while ($r =$result->fetch())
				{				
			 	    $item=array(
			 	    	"table" => $table,
				        "id" => $r["ID_INSPECTEUR"],
				        "id_specialite" => $r["ID_SPECIALITE"],				        
				        "nom" => $r["NOM_INSPECTEUR"],
				        "prenom" => $r["PERNOM_INSPECTEUR"],
				        "login" => $r["LOGIN"],
				        "mdp" => $r["MDP"]
				    );
			 	}

			}
				
				break;
			case 'gerant':
			{}
				
				break;
			case 'visite':
			{}
				
				break;
		}
	}	
}


echo json_encode($item);
?>