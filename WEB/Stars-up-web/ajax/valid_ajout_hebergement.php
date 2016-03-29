<?php


include_once('../class/mypdo.class.php');

$errors         = array();


 $tab=array();
$mypdo=new mypdo();

if(isset($_REQUEST['departement'])){
$tab['departement']=$_REQUEST['departement'];}
$tab['nom']="try";
//$tab['adresse']=$_REQUIRE['adresse'];
//$tab['ville']=$_REQUIERE['ville'];
//$tab['horraire']=$_REQUIERe['horraire'];


//$this->mypdo->insert_hebergement($tab)

echo json_encode(array($tab));
?>