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
                .
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
        <ul class="nav nav-pills nav-justified nav-inverse">
            <li id ="lihotel" role="presentation"><a id="hotel">Hotel</a></li>
            <li id ="licamping" role="presentation"><a id ="camping">Camping</a></li>
            <li id = "lichambre" role="presentation"><a name ="x" id ="chambre">Chambre d\'hote</a></li>
        </ul>
        
        </form>
        <div class="well well-lg" id="resultajax">

        </div>
        </div>';
        return $form;
    }


}

?>