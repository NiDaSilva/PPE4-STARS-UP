<?php
include 'mypdo.class.php';
class admin_controller{

    private $vpdo;
    private $db;
    public function __construct() {
        $this->vpdo = new mypdo ();
        //$this->db = $this->vpdo->connexion;
    }
    public function __get($propriete) {
        switch ($propriete) {
            case 'vpdo' :
            {
                return $this->vpdo;
                break;
            }
            case 'db' :
            {
                return $this->db;
                break;
            }
        }
    }


    public function return_table($nom_table,$x)
    {
        $result= $this->vpdo->return_table($nom_table,$x,6);
        switch ($nom_table) 
        {
            case 'hebergement' : 
            {
                $retour ='
                <table class="table">
                    <thead>
                    <tr>
                        <th>#</th>
                        <th>NOM</th>
                        <th>VILLE</th>
                        <th>ACTION</th>
                    </tr>
                    </thead>
                    <tbody>';                    
                    while ($row =$result->fetch())
                    {
                        $retour = $retour .'
                        <tr>
                        <td>'.$row['ID_HEBERGEMENT'].'</td>
                        <td>'.$row['NOM_HEBERGEMENT'].'</td>
                        <td>'.$row['VILLE_HEBERGEMENT'].'</td>
                        <td>
                            <div class="btn-group btn-group-xs" role="group" aria-label="...">  
                              <button type="button" class="btn btn-success">Update</button>
                              <button type="button" class="btn btn-danger">Delete</button>
                            </div>
                        </td>
                        </tr>';
                    }
                    $retour = $retour .'
                    </tbody>
                </table>
                ';
                break;
            }
            case 'inspecteur' : 
            {
                $retour ='
                <table class="table">
                    <thead>
                    <tr>
                        <th>#</th>
                        <th>NOM</th>
                        <th>PRENOM</th>
                        <th>ACTION</th>
                    </tr>
                    </thead>
                    <tbody>';                    
                    while ($row =$result->fetch())
                    {
                        $retour = $retour .'
                        <tr>
                        <td>'.$row['ID_INSPECTEUR'].'</td>
                        <td>'.$row['NOM_INSPECTEUR'].'</td>
                        <td>'.$row['PERNOM_INSPECTEUR'].'</td>
                        <td>
                            <div class="btn-group btn-group-xs" role="group" aria-label="...">  
                              <button type="button" class="btn btn-success">Update</button>
                              <button type="button" class="btn btn-danger">Delete</button>
                            </div>
                        </td>
                        </tr>';
                    }
                    $retour = $retour .'
                    </tbody>
                </table>
                ';
                break;
            }
        }        
        return $retour;
    }

    public function pagination($perPage)
    {
        $nbRow= $this->vpdo->count_row($_POST['nomtable']);
        $nbpage= ceil($nbRow/$perPage);
        $retour = '
        <div>
        <nav>
          <ul class="pagination">
            <li>
              <a href="#" aria-label="Previous">
                <span aria-hidden="true">&laquo;</span>
              </a>
            </li>';
            for ($i=1; $i <= $nbpage ; $i++) { 
               $retour= $retour.'<li><a href="?page='.$i.'&#about">'.$i.'</a></li>';
            }
        $retour= $retour.'
            <li>
              <a href="#" aria-label="Next">
                <span aria-hidden="true">&raquo;</span>
              </a>
            </li>
          </ul>
        </nav>
        </div>';
        return $retour;
    }


    function corps_admin(){
        $retour= '
            <div class="panel panel-default">
                <div class="panel-heading">
                    <h3 class="panel-title">Selectionner une table</h3>
                </div>  
                <div class="panel-body">
                <form id=select method="post">
                    <select id="nomtable" name="nomtable" class="form-control" onChange="document.getElementById(\'select\').submit()"> 
                    <option value="" disabled selected>Select your option</option>                  
                    <option value ="hebergement">Hebergement</option>
                    <option value="inspecteur">Inspecteur</option>
                    </select>
                </form>
                </div>  
            </div>';
        if (isset($_POST['nomtable']))
        {
                    $retour=$retour.'
                <div class="well well-lg">
                    <h3 style="color:black">'.$_POST['nomtable'].'</h3>
                    <div style="padding:5px">'.

                        $this->return_table($_POST['nomtable'],$_GET['page']).$this->pagination(6).
                    '<a class="btn btn-success"href="admin_new.php?type='.$_POST['nomtable'].'">NEW</a>
                    </div>
                </div>';
          
        }


                
                       
            return $retour;
    }

    /*******NEW******/

    public function corps_new($type)
    {   
        switch ($type) {
            case 'hebergement':
                if(!isset($_GET['heber']))
                {
                    $_GET['heber']='hotel';
                }
                $heberg=$_GET['heber'];
                switch ($heberg) {
                    case 'hotel':
                    {
                        $form='
                            <ul class="nav nav-pills nav-justified">
                                <li role="presentation" class="active"><a href="#">Hotel</a></li>
                                <li role="presentation"><a href="?type=hebergement&heber=camping">Camping</a></li>
                                <li role="presentation"><a href="?type=hebergement&heber=chambre">Chambre d\'hote</a></li>
                            </ul>
                            <div class="well well-lg">
                                <div class="form-group row">
                                    <label for="departement" class="col-sm-2 form-control-label">Département</label>
                                    <div class="col-sm-10">
                                        <select class="form-control" id="departement" name="departement">
                                            <option selected>- Departement -</option>';
                                            $result= $this->vpdo->return_table('departement',0,0);
                                            while ($row =$result->fetch())
                                            {
                                                $form=$form.'<option value="'.$row['ID_DEPARTEMENT'].'">'.$row['LIBELLE_DEPARTEMENT'].'</option>';
                                            }
                                            $form=$form.'                                        
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

                                <button type="submit" class="btn btn-primary">Submit</button>
                                
                            </div>
                            ';
                    }

                        break;
                    case 'camping':
                    {
                        $form='
                            <ul class="nav nav-pills nav-justified">
                                <li role="presentation"><a href="?type=hebergement&heber=hotel">Hotel</a></li>
                                <li role="presentation" class="active"><a>Camping</a></li>
                                <li role="presentation"><a href="?type=hebergement&heber=chambre">Chambre d\'hote</a></li>
                            </ul>
                            <div class="well well-lg">
                            <div class="form-group row">
                                    <label for="departement" class="col-sm-2 form-control-label">Département</label>
                                    <div class="col-sm-10">
                                        <select class="form-control" id="departement" name="departement">
                                            <option selected>- Departement -</option>';
                                            $result= $this->vpdo->return_table('departement',0,0);
                                            while ($row =$result->fetch())
                                            {
                                                $form=$form.'<option value="'.$row['ID_DEPARTEMENT'].'">'.$row['LIBELLE_DEPARTEMENT'].'</option>';
                                            }
                                            $form=$form.'                                        
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
                            </div>
                            ';
                    }
                        break;
                    case 'chambre':
                    {
                        $form='
                            <ul class="nav nav-pills nav-justified nav-inverse">
                                <li role="presentation"><a href="?type=hebergement&heber=hotel">Hotel</a></li>
                                <li role="presentation"><a href="?type=hebergement&heber=camping">Camping</a></li>
                                <li role="presentation" class="active"><a>Chambre d\'hote</a></li>
                            </ul>
                            <div class="well well-lg">
                            <div class="form-group row">
                                    <label for="departement" class="col-sm-2 form-control-label">Département</label>
                                    <div class="col-sm-10">
                                        <select class="form-control" id="departement" name="departement">
                                            <option selected>- Departement -</option>';
                                            $result= $this->vpdo->return_table('departement',0,0);
                                            while ($row =$result->fetch())
                                            {
                                                $form=$form.'<option value="'.$row['ID_DEPARTEMENT'].'">'.$row['LIBELLE_DEPARTEMENT'].'</option>';
                                            }
                                            $form=$form.'                                        
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
                
                break;
        }
        $retour='
        <div class="well well-lg">
        <form id="new" method="post">'.
        $form
        .'</form>
        </div>
        ';
        return $retour;
    }


}

?>