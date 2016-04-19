<?php
//envoi du formulaire hebergement.

include_once('../class/mypdo.class.php');
$vpdo=new mypdo();


$script = '
<script type="text/javascript">
$("#submit").click(function(){
    $.ajax({
                url: "../ajax/valid_ajout_hebergement.php",
                type: "GET",
                data: ({

                    table : $("#table").val(),
                    departement : $("#departement").val(),
                    gerant : $("#gerant").val(),
                    nom : $("#nom").val(),
                    adresse : $("#adresse").val(),
                    ville : $("#ville").val(),
                    horaire : $("#horaire").val(),

                    nbresto : $("#nbresto").val(),
                    chefresto : $("#chefresto").val(),

                    nbchambre : $("#nbchambre").val(),
                    nbcuisine : $("#nbcuisine").val()
                }),

                success: function (data) {
                    $("#alertsubmit").empty();
                    var d = $.parseJSON(data);
                   $("#alertsubmit").append(d);
                   $("#table").val(),
                    $("#departement").prop("selectedIndex",0);
                    $("#nom").val("");
                    $("#adresse").val("");
                    $("#ville").val("");
                    $("#horaire").val("");
                    $("#nbresto").val("");
                    $("#chefresto").val("");
                },
                error: function () {
                }
            })
});

</script>';

if(isset($_REQUEST['categ']))
{
	switch($_REQUEST['categ'])
	{
		case "hotel" :
		{
			$data='<div id="alertsubmit"></div><input type="hidden" class="form-control" id="table" value="1">
	            <div class="form-group row">
	                <label for="departement" class="col-sm-2 form-control-label">Département</label>
	                <div class="col-sm-10">
	                    <select class="form-control" id="departement" name="departement">
	                        <option selected>- Departement -</option>';
	                        $result= $vpdo->return_table('departement',0,0);
	                        while ($row =$result->fetch())
	                        {
	                            $data=$data.'<option value="'.$row['ID_DEPARTEMENT'].'">'.$row['LIBELLE_DEPARTEMENT'].'</option>';
	                        }
	                        $data=$data.'                                        
	                    </select>
	                </div>
	            </div>
                <div class="form-group row">
                    <label for="gerant" class="col-sm-2 form-control-label">Gérant</label>
                    <div class="col-sm-10">
                        <select class="form-control" id="gerant" name="gerant">
                            <option selected>- Gérant -</option>';
                            $result= $vpdo->return_table('gerant',0,0);
                            while ($row =$result->fetch())
                            {
                                $data=$data.'<option value="'.$row['ID_GERANT'].'">'.strtoupper($row['NOM_GERANT']).' '.$row['PRENOM_GERANT'].'</option>';
                            }
                            $data=$data.'                                        
                        </select>
                    </div>
                </div>
	            <div class="form-group row">
	                <label for="nom" class="col-sm-2 form-control-label">Nom hébergement</label>
	                <div class="col-sm-10">
	                    <input type="text" class="form-control" id="nom" placeholder="nom">
	                </div>
	            </div>
	            <div class="form-group row">
	                <label for="adresse" class="col-sm-2 form-control-label">Adresse hébergement</label>
	                <div class="col-sm-10">
	                    <input type="text" class="form-control" id="adresse" placeholder="ex: 2 rue bidule">
	                </div>
	            </div>
	            <div class="form-group row">
	                <label for="ville" class="col-sm-2 form-control-label">Ville</label>
	                <div class="col-sm-10">
	                    <input type="text" class="form-control" id="ville" placeholder="ex: 49000 Angers">
	                </div>
	            </div>
	            <div class="form-group row">
	                <label for="horaire" class="col-sm-2 form-control-label">Horaire</label>
	                <div class="col-sm-10">
	                    <input type="text" class="form-control" id="horaire" placeholder="ex: 8h - 18h">
	                </div>
	            </div>
	            <div class="form-group row">
	                <label for="nbresto" class="col-sm-2 form-control-label">Nombre resto</label>
	                <div class="col-sm-10">
	                    <input type="number" class="form-control" id="nbresto" default="1">
	                </div>
	            </div>
	            <div class="form-group row">
	                <label for="chefresto" class="col-sm-2 form-control-label">Chef Resto</label>
	                <div class="col-sm-10">
	                    <input type="text" class="form-control" id="chefresto">
	                </div>
	            </div>
                <a type="button" id="submit" class="btn btn-primary">Submit</a>
	        '.$script;
	    }
	    	break;
	    case "camping" :
	    {
	    	$data='<div id="alertsubmit"></div><input type="hidden" class="form-control" id="table" value="2">
               	<div class="form-group row">
                    <label for="departement" class="col-sm-2 form-control-label">Département</label>
                    <div class="col-sm-10">
                        <select class="form-control" id="departement" name="departement">
                            <option selected>- Departement -</option>';
                            $result= $vpdo->return_table('departement',0,0);
                            while ($row =$result->fetch())
                            {
                                $data=$data.'<option value="'.$row['ID_DEPARTEMENT'].'">'.$row['LIBELLE_DEPARTEMENT'].'</option>';
                            }
                            $data=$data.'                                        
                        </select>
                    </div>
                </div>
                <div class="form-group row">
                    <label for="gerant" class="col-sm-2 form-control-label">Gérant</label>
                    <div class="col-sm-10">
                        <select class="form-control" id="gerant" name="gerant">
                            <option selected>- Gérant -</option>';
                            $result= $vpdo->return_table('gerant',0,0);
                            while ($row =$result->fetch())
                            {
                                $data=$data.'<option value="'.$row['ID_GERANT'].'">'.strtoupper($row['NOM_GERANT']).' '.$row['PRENOM_GERANT'].'</option>';
                            }
                            $data=$data.'                                        
                        </select>
                    </div>
                </div>
                <div class="form-group row">
                    <label for="nom" class="col-sm-2 form-control-label">Nom hébergement</label>
                    <div class="col-sm-10">
                        <input type="text" class="form-control" id="nom" placeholder="nom">
                    </div>
                </div>
                <div class="form-group row">
                    <label for="adresse" class="col-sm-2 form-control-label">Adresse hébergement</label>
                    <div class="col-sm-10">
                        <input type="text" class="form-control" id="adresse" placeholder="ex: 2 rue bidule">
                    </div>
                </div>
                <div class="form-group row">
                    <label for="ville" class="col-sm-2 form-control-label">Ville</label>
                    <div class="col-sm-10">
                        <input type="text" class="form-control" id="ville" placeholder="ex: 49000 Angers">
                    </div>
                </div>
                <div class="form-group row">
                    <label for="horaire" class="col-sm-2 form-control-label">Horaire</label>
                    <div class="col-sm-10">
                        <input type="text" class="form-control" id="horaire" placeholder="ex: 8h - 18h">
                    </div>
                </div> 
                <a type="button" id="submit" class="btn btn-primary">Submit</a>
        	'.$script;
	    }
	    	break;
	    case "chambre" :
	    {	    
	    	$data='<div id="alertsubmit"></div><input type="hidden" class="form-control" id="table" value="3">
            	<div class="form-group row">
                    <label for="departement" class="col-sm-2 form-control-label">Département</label>
                    <div class="col-sm-10">
                        <select class="form-control" id="departement" name="departement">
                            <option selected>- Departement -</option>';
                            $result= $vpdo->return_table('departement',0,0);
                            while ($row =$result->fetch())
                            {
                                $data=$data.'<option value="'.$row['ID_DEPARTEMENT'].'">'.$row['LIBELLE_DEPARTEMENT'].'</option>';
                            }
                            $data=$data.'                                        
                        </select>
                    </div>
                </div>
                <div class="form-group row">
                    <label for="gerant" class="col-sm-2 form-control-label">Gérant</label>
                    <div class="col-sm-10">
                        <select class="form-control" id="gerant" name="gerant">
                            <option selected>- Gérant -</option>';
                            $result= $vpdo->return_table('gerant',0,0);
                            while ($row =$result->fetch())
                            {
                                $data=$data.'<option value="'.$row['ID_GERANT'].'">'.strtoupper($row['NOM_GERANT']).' '.$row['PRENOM_GERANT'].'</option>';
                            }
                            $data=$data.'                                        
                        </select>
                    </div>
                </div>
                <div class="form-group row">
                    <label for="nom" class="col-sm-2 form-control-label">Nom hébergement</label>
                    <div class="col-sm-10">
                        <input type="text" class="form-control" id="nom" placeholder="nom">
                    </div>
                </div>
                <div class="form-group row">
                    <label for="adresse" class="col-sm-2 form-control-label">Adresse hébergement</label>
                    <div class="col-sm-10">
                        <input type="text" class="form-control" id="adresse" placeholder="ex: 2 rue bidule">
                    </div>
                </div>
                <div class="form-group row">
                    <label for="ville" class="col-sm-2 form-control-label">Ville</label>
                    <div class="col-sm-10">
                        <input type="text" class="form-control" id="ville" placeholder="ex: 49000 Angers">
                    </div>
                </div>
                <div class="form-group row">
                    <label for="horaire" class="col-sm-2 form-control-label">Horaire</label>
                    <div class="col-sm-10">
                        <input type="text" class="form-control" id="horaire" placeholder="ex: 8h - 18h">
                    </div>
                </div> 
                <div class="form-group row">
                    <label for="nbchambre" class="col-sm-2 form-control-label">Nombre de chambre</label>
                    <div class="col-sm-10">
                        <input type="number" class="form-control" id="nbchambre">
                    </div>
                </div>
                <div class="form-group row">
                    <label for="nbcuisine" class="col-sm-2 form-control-label">Nombre de cuisine</label>
                    <div class="col-sm-10">
                        <input type="number" class="form-control" id="nbcuisine">
                    </div>
                </div> 
                <a type="button" id="submit" class="btn btn-primary">Submit</a>
            '.$script;	
	    }
	    	break;
	}

}


echo json_encode($data);
?>

