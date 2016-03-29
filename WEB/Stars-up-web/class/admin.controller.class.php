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


    public function corps_admin(){
        $retour= '
            <div class="panel panel-default">
                <div class="panel-heading">
                    <h3 class="panel-title">Selectionner une table</h3>
                </div>  
                <div class="panel-body">
                <form id=select method="post">
                    <select id="nomtable" name="nomtable" class="form-control"> 
                    <option value="" disabled selected>Select your option</option>                  
                    <option value ="hebergement">Hebergement</option>
                    <option value="inspecteur">Inspecteur</option>
                    <option value="gerant">gerant</option>
                    </select>
                </form>
                </div>  
            </div>
            <div id="resultajax" class="well well-lg">
            </div>
            ';
            return $retour;
    }

    /*******NEW******/

    public function corps_new($type)
    {

        $form=
        '<div class="well well-lg">
        <form id="new" name="new" method="post">
        <span><h2><a href="../view/consultation_admin.php"><i class="fa fa-chevron-circle-left"> Retour vers consultation</i></a></h2></span>';
        switch($type){
            case "hebergement" :
            {
                $form=$form.'                
                            <ul class="nav nav-pills nav-justified nav-inverse">
                                <li id ="lihotel" role="presentation"><a id="hotel">Hotel</a></li>
                                <li id ="licamping" role="presentation"><a id ="camping">Camping</a></li>
                                <li id = "lichambre" role="presentation"><a name ="x" id ="chambre">Chambre d\'hote</a></li>
                            </ul>

                            <div class="well well-lg" id="resultajax">
                            </div>
                            ';
            }
            break;
            case "inspecteur" :
            {
                $form=$form.'
                <div class="well well-lg">
                    <div class="form-group row">
                        <label for="departement" class="col-sm-2 form-control-label">Département</label>
                        <div class="col-sm-10">
                            <select class="form-control" id="departement" name="departement">
                                <option selected>- Spécialité -</option>';
                                $result= $this->vpdo->return_table('specialite',0,0);
                                while ($row =$result->fetch())
                                {
                                    $form=$form.'<option value="'.$row['ID_SPECIALITE'].'">'.$row['LIBELLE_SPECIALITE'].'</option>';
                                }
                                $form=$form.'                                        
                            </select>
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="nom" class="col-sm-2 form-control-label">Nom</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" name="nom" placeholder="nom">
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="prenom" class="col-sm-2 form-control-label">Prenom</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" name="prenom" placeholder="Prenom">
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="login" class="col-sm-2 form-control-label">Login</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" name="login" placeholder="Login">
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="mdp" class="col-sm-2 form-control-label">Password</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" name="mdp" placeholder="••••••••">
                        </div>
                    </div>                    
                    <button type="button" id="submit" name="submit" class="btn btn-primary">Submit</button>
                </div> ';
            }
        } 
        $form=$form.'        
        </form>
        </div>';
        return $form;
    }


}

?>