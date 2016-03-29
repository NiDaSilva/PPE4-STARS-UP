<?php
include 'mypdo.class.php';
class conn_controller{

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

    public function corps_connexion()
    {
        $r= '
            <div class="well well-lg">
            <center><fieldset><h2><i class="fa fa-play-circle"></i>  <span class="light">Star\'s</span> UP</h2></fieldset></center>
                <div class="col lg-12">
                    <div class="row">

                      <div class="col-sm-4 col-md-6">

                        <div class="thumbnail">                       
                          <div class="caption">
                          </br>
                            <h3>Sign in</h3>
                            <form>
                            <div class="well well-lg">                          
                            <div class="form-group row">
                                
                                <div class="form-group row">
                                    <div class="col-sm-12">
                                    </div>
                                </div>  
                                <div class="form-group row ch" style="padding:10px">
                                    <ul id="choix" class="nav nav-pills nav-justified nav-inverse">
                                        <li id ="liadmin" role="presentation" class="liconn"><a class="switch" name="admin">Admin</a></li>
                                        <li id ="ligerant" role="presentation" class="liconn"><a class="switch" name="gerant">Gerant</a></li>
                                        <li id = "liinspecteur" role="presentation" class="liconn"><a class="switch" name="inspecteur">Inspecteur</a></li>
                                    </ul>
                                </div>                        
                                <div class="form-group row">
                                    <div class="col-sm-12">
                                        <div class="input-group">
                                          <span class="input-group-addon" id="basic-addon1"><span class="glyphicon glyphicon-user" aria-hidden="true"></span></span>
                                          <input type="text" id="login" class="form-control" placeholder="Username" aria-describedby="basic-addon1">
                                        </div>
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <div class="col-sm-12">
                                        <div class="input-group">
                                          <span class="input-group-addon" id="basic-addon1"><span class="glyphicon glyphicon-lock" aria-hidden="true"></span></span>
                                          <input type="password" id="password" class="form-control" placeholder="••••••••" aria-describedby="basic-addon1">
                                        </div>
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <div class="col-sm-12">
                                    <a href="#">mot de passe oublier ?</a>
                                    </div>
                                </div>
                                
                                <div class="form-group row">
                                    <div class="col-sm-12">
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <div class="col-sm-12">
                                    </div>
                                </div>                              
                            </div>
                            </div> 
                            <div class="form-group row">
                                    <div class="col-sm-12">
                                    <a href="#" id="signin" class="btn btn-primary" role="button">Sign in</a>
                                    </div>
                                </div>                         
                            </form>
                          </div>
                        </div>

                      </div>

                      <div class="col-sm-4 col-md-6">

                        <div class="thumbnail">                       
                          <div class="caption">
                          </br>
                            <h3>Sign up</h3>
                            <form>
                            <div class="well well-lg">
                            <div class="form-group row">
                            <div class="form-group row" style="padding:10px">
                                    <ul class="nav nav-pills nav-justified nav-inverse">
                                        <li id ="ligerant1" role="presentation" class="liconn"><a class="switch" name="gerant1">Gerant</a></li>
                                        <li id = "liinspecteur1" role="presentation" class="liconn"><a class="switch" name="inspecteur1">Inspecteur</a></li>
                                    </ul>
                                </div>
                                <div class="form-group row">
                                    <div class="col-sm-12">
                                        <div class="input-group">
                                          <span class="input-group-addon" id="basic-addon1"><span class="glyphicon glyphicon-pencil" aria-hidden="true"></span></span>
                                          <input type="text" id="login" class="form-control" placeholder="Nom" aria-describedby="basic-addon1">
                                        </div>
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <div class="col-sm-12">
                                        <div class="input-group">
                                          <span class="input-group-addon" id="basic-addon1"><span class="glyphicon glyphicon-pencil" aria-hidden="true"></span></span>
                                          <input type="text" id="login" class="form-control" placeholder="Prenom" aria-describedby="basic-addon1">
                                        </div>
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <div class="col-sm-12">
                                        <div class="input-group">
                                          <span class="input-group-addon" id="basic-addon1"><span class="glyphicon glyphicon-user" aria-hidden="true"></span></span>
                                          <input type="text" id="login" class="form-control" placeholder="Username" aria-describedby="basic-addon1">
                                        </div>
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <div class="col-sm-12">
                                        <div class="input-group">
                                          <span class="input-group-addon" id="basic-addon1"><span class="glyphicon glyphicon-lock" aria-hidden="true"></span></span>
                                          <input type="password" id="password" class="form-control" placeholder="••••••••" aria-describedby="basic-addon1">
                                        </div>
                                    </div>
                                </div>                                                            
                            </div>
                            </div>
                            <div class="form-group row">
                                    <div class="col-sm-12">
                                        <a href="#" class="btn btn-primary" role="button">Sign up</a>
                                </div>
                                </div>                         
                            </form>
                          </div>
                        </div>

                      </div>

                    </div>
                </div>
            </div>'
       ;
       return $r;
    }

}
?>