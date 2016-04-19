<?php
//envoi des tableau de donnée.

include_once('../class/mypdo.class.php');

$vpdo=new mypdo();
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

if(isset($_REQUEST['table']))
{
	switch($_REQUEST['table'])
	{
		case "hebergement" :
		{
			$data='
			<h3 style="color:black">'.$_REQUEST['table'].'</h3>
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
                    $result= $vpdo->return_table($_REQUEST['table'],$_GET['page'],6);
                    
                    while ($row =$result->fetch())
                    {
                        $data = $data .'
                        <tr>
                        <td></td>
                        <td>'.$row['NOM_HEBERGEMENT'].'</td>
                        <td>'.$row['VILLE_HEBERGEMENT'].'</td>
                        <td>
                            <div class="btn-group btn-group-xs" role="group" aria-label="...">
                              <a class="btn btn-success"href="admin_update.php?type='.$_REQUEST['table'].'&id='.$row['ID_HEBERGEMENT'].'">UPDATE</a>
                              <a class="btn btn-danger delete" name="'.$row['ID_HEBERGEMENT'].'">Delete</a>
                            </div>
                        </td>
                        </tr>';
                        
                    }
                    $data=$data.
                    '</tbody>
                </table>';
                $nbRow= $vpdo->count_row($_REQUEST['table']);
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
				               $data= $data.'<li><a id="page" class="page">'.$i.'</a></li>';
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
                <a class="btn btn-success"href="admin_new.php?type='.$_REQUEST['table'].'">NEW</a>
			</div>
			'.$script	;
		}
		break;
		case "inspecteur" :
		{
			$data='
			<h3 style="color:black">'.$_REQUEST['table'].'</h3>
			<div id="resultat1"></div>
			    <div id="pagination" style="padding:5px">		
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
                    if(!isset($_GET['page'])){$_GET['page'] = 1;}
                    $result= $vpdo->return_table($_REQUEST['table'],$_GET['page'],3);
                    while ($row =$result->fetch())
                    {
                        $data = $data .'
                        <tr>
                        <td></td>
                        <td>'.$row['NOM_INSPECTEUR'].'</td>
                        <td>'.$row['PERNOM_INSPECTEUR'].'</td>
                        <td>
                            <div class="btn-group btn-group-xs" role="group" aria-label="...">  
                              <a class="btn btn-success"href="admin_update.php?type='.$_REQUEST['table'].'&id='.$row['ID_INSPECTEUR'].'">UPDATE</a>
                              <a class="btn btn-danger delete" name="'.$row['ID_INSPECTEUR'].'">Delete</a>
                            </div>
                        </td>
                        </tr>';
                    }
                    $data=$data.
                    '</tbody>
                </table>';
                $nbRow= $vpdo->count_row($_REQUEST['table']);
				        $nbpage= ceil($nbRow/3);//6 => nb par page
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
				               $data= $data.'<li><a id="page" class="page">'.$i.'</a></li>';
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
                <a class="btn btn-success"href="admin_new.php?type='.$_REQUEST['table'].'">NEW</a>
			</div>
			'.$script	;
		}
		break;
		case "gerant" :
		{
			$data='
			<h3 style="color:black">'.$_REQUEST['table'].'</h3>
			<div id="resultat1"></div>
			    <div id="pagination" style="padding:5px">		
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
                    if(!isset($_GET['page'])){$_GET['page'] = 1;}
                    $result= $vpdo->return_table($_REQUEST['table'],$_GET['page'],3);
                    while ($row =$result->fetch())
                    {
                        $data = $data .'
                        <tr>
                        <td></td>
                        <td>'.$row['NOM_GERANT'].'</td>
                        <td>'.$row['PRENOM_GERANT'].'</td>
                        <td>
                            <div class="btn-group btn-group-xs" role="group" aria-label="...">
                              <a href="admin_update.php?type='.$_REQUEST['table'].'&id='.$row['ID_GERANT'].'" class="btn btn-success">Update</a>
                              <a class="btn btn-danger delete" name="'.$row['ID_GERANT'].'">Delete</a>
                            </div>
                        </td>
                        </tr>';
                    }
                    $data=$data.
                    '</tbody>
                </table>';
                $nbRow= $vpdo->count_row($_REQUEST['table']);
				        $nbpage= ceil($nbRow/3);//6 => nb par page
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
				               $data= $data.'<li><a id="page" class="page">'.$i.'</a></li>';
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
                <a class="btn btn-success"href="admin_new.php?type='.$_REQUEST['table'].'">NEW</a>
			</div>
			

			'.$script	;
		}
		break;

	}
	$data= $data.'';
}

echo json_encode($data);
?>

