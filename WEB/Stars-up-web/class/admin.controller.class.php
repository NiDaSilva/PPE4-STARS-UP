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

    public function corps_gerantvisite(){
        $vpdo=new mypdo();
            session_start();
            $form=
        '<div class="well well-lg">
        <form id="new" name="new" method="post">
        ';
if(!isset($_GET["id"])){$_GET["id"] = " ";}
                $form=$form.'
                <div id="alertsubmit">
                            </div>
                <input type="hidden" class="form-control" id="table" value="visite">
                <input type="hidden" class="form-control" id="id" value='.$_GET['id'].'>
                <div class="well well-lg">
                    <div class="form-group row">
                        <label for="hebergement" class="col-sm-2 form-control-label">HEBERGEMENT</label>
                        <div class="col-sm-10">
                            <select class="form-control" id="hebergement" name="hebergement">
                                <option selected>- hebergement -</option>';
                                $result= $this->vpdo->return_table2('hebergement',0,0,$_SESSION['id']);
                                while ($row =$result->fetch())
                                {
                                    $form=$form.'<option value="'.$row['ID_HEBERGEMENT'].'">'.$row['NOM_HEBERGEMENT'].'</option>';
                                }
                                $form=$form.'                                        
                            </select>
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="saison" class="col-sm-2 form-control-label">SAISON</label>
                        <div class="col-sm-10">
                            <div class="input-group">
                                <div class="col-sm-6">
                                <select class="form-control" id="saison" name="saison">
                                    <option selected>-saison -</option>
                                    <option value="Hiver">Hiver</option> 
                                    <option value="Printemps">Printemps</option> 
                                    <option value="Eté">Eté</option> 
                                    <option value="Automne">Automne</option>
                                </select>
                                </div>
                                <div class="col-sm-6">
                                <select class="form-control" id="annee" name="annee">
                                <option selected>- Année -</option>';
                                $annee= intval(date("Y"));
                                for ($i=$annee; $i < ($annee+10) ; $i++) { 
                                   $form=$form.'<option value="'.$i.'">'.$i.'</option>';
                                }
                                $form=$form.'                                        
                            </select>
                                </div>
                            </div>                            
                        </div>
                    </div>
                    
                    <button type="button" id="submitvisite" name="submit" class="btn btn-primary">Submit</button>
                </div> 
                </form>
                        </div>';
        return $form;
    }

    public function corps_gerant(){
            $vpdo=new mypdo();
            session_start();
        $script='
    <script type="text/javascript">
        $(".page").click(function(){
            $.ajax({
                url: "../ajax/switch_tableau_bdd.php",
                type: "GET",
                data: ({page : $(this).text(),
                        table : $("#nomtable").val()}),

                success: function (data) {

                   $("#resultajax").empty();
                   var d = $.parseJSON(data)
                   $("#resultajax").append(d);
                },
                error: function () {
                    alert("fail");
                }
            })
        });
    $(".delete").click(function(){
            $.ajax({
                url: "../ajax/delete.php",
                type: "GET",
                data: ({id : $(this).attr("name"),
                        table : $("#nomtable").val()}),

                success: function (data) {
                $("#nomtable").trigger("change");
                   $("#resultat1").empty();
                   $("#resultat1").addClass("alert alert-success");
                   var d = $.parseJSON(data);
                   $("#resultat1").append(d);

                },
                error: function () {
                    $("#resultat1").empty();
                    $("#resultat1").addClass("alert alert-danger");
                   var d = $.parseJSON(data);
                   $("#resultat1").append(d);
                }
            })
        });

        
    </script>';
                    $data='
                   <div id="resultajax" class="well well-lg"> 
            <h3 style="color:black">Mes hebergements</h3>
            <div id="resultat1"></div>
                <div id="pagination" style="padding:5px">       
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
                    if(!isset($_GET['page'])){$_GET['page'] = 1;}
                    if($vpdo->count_row('hebergement') != 0)
                    {
                        $result= $vpdo->return_table2('hebergement',$_GET['page'],6,$_SESSION['id']);                    
                        while ($row =$result->fetch())
                        {
                            $data = $data .'
                            <tr>
                            <td></td>
                            <td>'.$row['NOM_HEBERGEMENT'].'</td>
                            <td>'.$row['VILLE_HEBERGEMENT'].'</td>
                            <td>
                                <div class="btn-group btn-group-xs" role="group" aria-label="...">  
                                  <a class="btn btn-success"href="admin_update.php?type="hebergement"&id='.$row['ID_HEBERGEMENT'].'">UPDATE</a>
                                  <a class="btn btn-danger delete" name="'.$row['ID_HEBERGEMENT'].'">Delete</a>
                                </div>
                            </td>
                            </tr>';
                            
                        }
                    }
                    $data=$data.
                    '</tbody>
                </table>';
                $nbRow= $vpdo->count_row2('hebergement',$_SESSION['id']);
                        $nbpage= ceil($nbRow/6);//6 => nb par page
                        $data= $data.'
                        <div>
                        <nav>
                          <ul class="pagination">
                            <li>
                              <a href="#" aria-label="Previous">
                                <span aria-hidden="true">&laquo;</span>
                              </a>
                            </li>';
                            for ($i=1; $i <= $nbpage ; $i++) { 
                               $data= $data.'<li><a href="?page='.$i.'" class="page">'.$i.'</a></li>';
                            }
                        $data= $data.'
                            <li>
                              <a href="#" aria-label="Next">
                                <span aria-hidden="true">&raquo;</span>
                              </a>
                            </li>
                          </ul>
                        </nav>
                        </div>
                <a class="btn btn-success"href="admin_new.php?type=hebergement">NEW</a>
            </div></div>
            '.$script   ;
            return $data;

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
                    <option value="gerant">Gérant</option>
                    <option value="visite">Visite</option>
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
                if(!isset($_GET["id"])){$_GET["id"] = " ";}

                $form=$form.'
                            <input type="hidden" class="form-control" id="categ" value="'.$_GET['type'].'">
                             <input type="hidden" class="form-control" id="id" value='.$_GET['id'].'>
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
                if(!isset($_GET["id"])){$_GET["id"] = " ";}
                $form=$form.'
                <div id="alertsubmit">
                            </div>
                <input type="hidden" class="form-control" id="table" value='.$_GET['type'].'>
                <input type="hidden" class="form-control" id="id" value='.$_GET['id'].'>
                <div class="well well-lg">
                    <div class="form-group row">
                        <label for="departement" class="col-sm-2 form-control-label">Département</label>
                        <div class="col-sm-10">
                            <select class="form-control" id="specialite" name="specialite">
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
                            <input type="text" class="form-control" id="nom" placeholder="nom">
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="prenom" class="col-sm-2 form-control-label">Prenom</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="prenom" placeholder="Prenom">
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="login" class="col-sm-2 form-control-label">Login</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="login" placeholder="Login">
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="mdp" class="col-sm-2 form-control-label">Password</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="mdp" placeholder="••••••••">
                        </div>
                    </div>                    
                    <button type="button" id="submitinspecteur" name="submit" class="btn btn-primary">Submit</button>
                </div> ';
            }
            break;
            case "gerant" :
            {
                if(!isset($_GET["id"])){$_GET["id"] = " ";}
                $form=$form.'
                <div id="alertsubmit">
                            </div>
                <input type="hidden" class="form-control" id="table" value='.$_GET['type'].'>
                <input type="hidden" class="form-control" id="id" value='.$_GET['id'].'>
                <div class="well well-lg">
                    <div class="form-group row">
                        <label for="nom" class="col-sm-2 form-control-label">Nom</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="nom" placeholder="nom">
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="prenom" class="col-sm-2 form-control-label">Prenom</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="prenom" placeholder="Prenom">
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="login" class="col-sm-2 form-control-label">Login</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="login" placeholder="Login">
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="mdp" class="col-sm-2 form-control-label">Password</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="mdp" placeholder="••••••••">
                        </div>
                    </div>                    
                    <button type="button" id="submitgerant" name="submit" class="btn btn-primary">Submit</button>
                </div> ';
            }
            break;
            case "visite" :
            {
                if(!isset($_GET["id"])){$_GET["id"] = " ";}
                $form=$form.'
                <div id="alertsubmit">
                            </div>
                <input type="hidden" class="form-control" id="table" value='.$_GET['type'].'>
                <input type="hidden" class="form-control" id="id" value='.$_GET['id'].'>
                <div class="well well-lg">
                    <div class="form-group row">
                        <label for="hebergement" class="col-sm-2 form-control-label">HEBERGEMENT</label>
                        <div class="col-sm-10">
                            <select class="form-control" id="hebergement" name="hebergement">
                                <option selected>- hebergement -</option>';
                                $result= $this->vpdo->return_table('hebergement',0,0);
                                while ($row =$result->fetch())
                                {
                                    $form=$form.'<option value="'.$row['ID_HEBERGEMENT'].'">'.$row['NOM_HEBERGEMENT'].'</option>';
                                }
                                $form=$form.'                                        
                            </select>
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="saison" class="col-sm-2 form-control-label">SAISON</label>
                        <div class="col-sm-10">
                            <div class="input-group">
                                <div class="col-sm-6">
                                <select class="form-control" id="saison" name="saison">
                                    <option selected>-saison -</option>
                                    <option value="Hiver">Hiver</option> 
                                    <option value="Printemps">Printemps</option> 
                                    <option value="Eté">Eté</option> 
                                    <option value="Automne">Automne</option>
                                </select>
                                </div>
                                <div class="col-sm-6">
                                <select class="form-control" id="annee" name="annee">
                                <option selected>- Année -</option>';
                                $annee= intval(date("Y"));
                                for ($i=$annee; $i < ($annee+10) ; $i++) { 
                                   $form=$form.'<option value="'.$i.'">'.$i.'</option>';
                                }
                                $form=$form.'                                        
                            </select>
                                </div>
                            </div>                            
                        </div>
                    </div>
                    <div class="form-group row hidenew">
                        <label for="inspecteur" class="col-sm-2 form-control-label">Inspecteur</label>
                        <div class="col-sm-10">
                            <select class="form-control" id="inspecteur" name="inspecteur">
                                <option selected value="null">- Inspecteur -</option>';
                                $result= $this->vpdo->return_table('inspecteur',0,0);
                                while ($row =$result->fetch())
                                {
                                    $form=$form.'<option value="'.$row['ID_INSPECTEUR'].'">'.$row['NOM_INSPECTEUR'].' '.$row['PERNOM_INSPECTEUR'].'</option>';
                                }
                                $form=$form.'                                        
                            </select>
                        </div>
                    </div>
                    <div class="form-group row hidenew">
                        <label for="etoile" class="col-sm-2 form-control-label">Etoile</label>
                        <div class="col-sm-10">
                            <input type="number" class="form-control" id="etoile">
                        </div>
                    </div>
                    <div class="form-group row hidenew">
                        <label for="date" class="col-sm-2 form-control-label">DATE HEURE</label>
                        <div class="col-sm-10">
                            <input type="datetime-local" class="form-control" id="date">
                        </div>
                    </div>
                    <div class="form-group row hidenew">
                        <label for="commentaire" class="col-sm-2 form-control-label">Commentaire</label>
                        <div class="col-sm-10">
                            <textarea class="form-control" id="commentaire"></textarea>
                        </div>
                    </div>
                    <div class="form-group row hidenew">
                        <label for="id_contrevisite" class="col-sm-2 form-control-label">contre visite de </label>
                        <div class="col-sm-10">
                            <select class="form-control" id="id_contrevisite" name="id_contrevisite">
                                <option selected value="null">- NULL -</option>';
                                $result= $this->vpdo->return_table('visite',0,0);
                                while ($row =$result->fetch())
                                {
                                    $form=$form.'<option value="'.$row['ID_VISITE'].'">'.$row['ID_VISITE'].'</option>';
                                }
                                $form=$form.'                                        
                            </select>
                        </div>
                    </div>
                    <button type="button" id="submitvisite" name="submit" class="btn btn-primary">Submit</button>
                </div> ';
            }
            break;

        } 
        $form=$form.'        
        </form>
        </div>';
        return $form;
    }


}

?>