<?php
include_once('../class/page_base.class.php');
include '../class/connexion.controller.class.php';

$controller = new con_controller();

$connexion = new page_base('login');

$connexion->corps='
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
								<div class="form-group row">
                                    <div class="col-sm-12">
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
                                <div class="form-group row">
                                    <div class="col-sm-12">
                                    <label class="radio-inline">
									  <input type="radio" name="inlineRadioOptions" id="inlineRadio1" value="option1"> Gerant
									</label>
									<label class="radio-inline">
									  <input type="radio" name="inlineRadioOptions" id="inlineRadio2" value="option2"> Inspecteur
									</label>
									<label class="radio-inline">
									  <input type="radio" name="inlineRadioOptions" id="inlineRadio3" value="option3"> Admin
									</label>
                                    </div>
                                </div>
								<div class="form-group row">
                                    <div class="col-sm-12">
									</div>
								</div>
                                <div class="form-group row">
                                    <div class="col-sm-12">
									<a href="#" class="btn btn-primary" role="button">Sign in</a>
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
                                <div class="form-group row">
                                    <div class="col-sm-12">
                                    <label class="radio-inline">
									  <input type="radio" name="inlineRadioOptions" id="inlineRadio1" value="option1"> Gerant
									</label>
									<label class="radio-inline">
									  <input type="radio" name="inlineRadioOptions" id="inlineRadio2" value="option2"> Inspecteur
									</label>
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <div class="col-sm-12">
                                		<a href="#" class="btn btn-primary" role="button">Sign up</a>
                                </div>
                                </div>
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

$connexion->afficher();
?>
