<?php
//envoi du formulaire hebergement.

include_once('../class/mypdo.class.php');
$vpdo=new mypdo();



$data = "test";
if(isset($_REQUEST['categ']))
{
	switch($_REQUEST['categ'])
	{
		case "hotel" :
		{
			$data='
			<div class="well well-lg">
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
	                <label for="nom" class="col-sm-2 form-control-label">Nom hébergement</label>
	                <div class="col-sm-10">
	                    <input type="text" class="form-control" name="nom" placeholder="nom">
	                </div>
	            </div>
	            <div class="form-group row">
	                <label for="adresse" class="col-sm-2 form-control-label">Adresse hébergement</label>
	                <div class="col-sm-10">
	                    <input type="text" class="form-control" name="adresse" placeholder="ex: 2 rue bidule">
	                </div>
	            </div>
	            <div class="form-group row">
	                <label for="ville" class="col-sm-2 form-control-label">Ville</label>
	                <div class="col-sm-10">
	                    <input type="text" class="form-control" name="ville" placeholder="ex: 49000 Angers">
	                </div>
	            </div>
	            <div class="form-group row">
	                <label for="horraire" class="col-sm-2 form-control-label">Horraire</label>
	                <div class="col-sm-10">
	                    <input type="text" class="form-control" name="horraire" placeholder="ex: 8h - 18h">
	                </div>
	            </div>
	            <div class="form-group row">
	                <label for="nbresto" class="col-sm-2 form-control-label">Nombre resto</label>
	                <div class="col-sm-10">
	                    <input type="number" class="form-control" name="nbresto" default="1">
	                </div>
	            </div>
	            <div class="form-group row">
	                <label for="chefresto" class="col-sm-2 form-control-label">Chef Resto</label>
	                <div class="col-sm-10">
	                    <input type="text" class="form-control" name="chefresto">
	                </div>
	            </div>
	            <button type="button" id="submit" name="submit" class="btn btn-primary">Submit</button>
	        </div>	     
	        ';
	    }
	    	break;
	    case "camping" :
	    {
	    	$data=
    		'<div class="well well-lg">
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
                    <label for="horraire" class="col-sm-2 form-control-label">Horraire</label>
                    <div class="col-sm-10">
                        <input type="text" class="form-control" id="horraire" placeholder="ex: 8h - 18h">
                    </div>
                </div> 
                <button type="submit" class="btn btn-primary">Submit</button>                               
        	</div>'
	         ;
	    }
	    	break;
	    case "chambre" :
	    {	    
	    	$data='
            <div class="well well-lg">
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
                    <label for="horraire" class="col-sm-2 form-control-label">Horraire</label>
                    <div class="col-sm-10">
                        <input type="text" class="form-control" id="horraire" placeholder="ex: 8h - 18h">
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
                <button type="submit" class="btn btn-primary">Submit</button>                              
            </div>
            ';	
	    }
	    	break;
	}

}


echo json_encode($data);
?>