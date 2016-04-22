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
				print_r('1er');
				$x=0;
				$id=0;					
				while ($r =$result->fetch())
				{
					print_r('2er');
			 	    $item=array(
				        "id" => $r["ID_HEBERGEMENT"],
				        "departement" => intval($r["ID_DEPARTEMENT"]),
				        "gerant" => intval($r["ID_GERANT"]),
				        "nom" => $r["NOM_HEBERGEMENT"],
				        "adresse" => $r["ADRESSE_HEBERGEMENT"],
				        "ville" => $r["VILLE_HEBERGEMENT"],
				        "horaire" => $r["HORAIRES"],
				        "specialite"  => $r["ID_SPECIALITE"]
				    );	
				    $x = $item['specialite'];
				    $id = $item['id'];
			 	}
			 	switch ($x) {
				    	case 1:
				    		{
				    			$result2= $vpdo->get_item('hotel',$id);
				    			while ($r2 =$result2->fetch()) {
				    				$item['nbresto'] = $r2['RESTAURANT_HOTEL'];
				    				$item['chefresto'] = $r2['CHEF_RESTAURANT_HOTEL'];
				    			}
				    		}		
				    	break;

				    	case 2:
				    		{}		
				    	break;

				    	case 3:
				    		{
				    			$result2= $vpdo->get_item('chambre_hote',$id);
				    			while ($r2 =$result2->fetch()) {
				    				$item['nbchambre'] = $r2['NOMBRE_CHAMBRE_HOTE'];
				    				$item['nbcuisine'] = $r2['CUISINE_CHAMBRE_HOTE'];
				    			}
				    		}		
				    	break;
				    	
				    }

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