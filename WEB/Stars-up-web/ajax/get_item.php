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
			{
				while ($r =$result->fetch())
				{				
			 	    $item=array(
			 	    	"table" => $table,
				        "id" => $r["ID_GERANT"],			        
				        "nom" => $r["NOM_GERANT"],
				        "prenom" => $r["PRENOM_GERANT"],
				        "login" => $r["LOGIN"],
				        "mdp" => $r["MDP"]
				    );
			 	}
			}
				
				break;
			case 'visite':
			{				
				while ($r =$result->fetch())
				{	$date = str_replace(" ", "T", strval($r["DATE_HEURE_VISITE"]));
					if ($r["ID_INSPECTEUR"] == null) {$r["ID_INSPECTEUR"]="null";}
					if ($r["ID_CONTREVISITE"] == null) {$r["ID_CONTREVISITE"]="null";}
			 	    $item=array(
			 	    	"table" => $table,
				        "id" => $r["ID_VISITE"],			        
				        "hebergement" => $r["ID_HEBERGEMENT"],
				        "inspecteur" => $r["ID_INSPECTEUR"],
				        "etoile" => $r["NOMBRE_ETOILE_VISITE"],
				        "commentaire" => $r["COMMENTAIRE_VISITE"],
				        "contrevisite" => $r["ID_CONTREVISITE"],
				        "date" => $date

				    );
				    $result2=$vpdo->get_item("saison",$r['ID_SAISON']);
				    while ($s =$result2->fetch())
				    {
				    	$i=substr($s['LIBELLE_SAISON'],-4);
				    	$item["annee"] = intval($i);
				    	$item['saison'] = strchr($s['LIBELLE_SAISON']," ".$i,true);
				    }

			 	}
			}
				
				break;
		}
	}	
}


echo json_encode($item);
?>