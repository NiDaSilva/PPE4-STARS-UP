<?php
//envoi du formulaire hebergement.

include_once('../class/mypdo.class.php');
$vpdo=new mypdo();
$data = 'ECHEC';
if(isset($_REQUEST['table']) && isset($_REQUEST['id']))
{
	$id=intval($_REQUEST['id']);
	$table=$_REQUEST['table'];

	$vpdo->delete($table,$id);
	$data = 'un '.$table.' à bien été supprimé';

	
}


echo json_encode($data);
?>