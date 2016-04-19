<?php
$lesVisites=array();
$i=0;
$editable=null;
include_once('../class/mypdo.class.php');
$vpdo=new mypdo();
session_start();
$id=$_SESSION["id"];
$result=$vpdo->get_visites($id);
if ($result) {
foreach  ($result as $r) {
    $today = date("Y-m-d H:i:s");
    $date = $r["DATE"];
    if ($date < $today) {
        $editable=false;
    }
    else
    {
        $editable=true;
    }
    $lesVisites[$i]=array(
        "id" => $r["IDV"],
        "title" => $r["NOM"],
        "start" => $r["DATE"],
        "overlap" => false,
        "startEditable" => $editable
    );
    $i++;
}
$tableau=array(
    "ok"   => true,
    "visites"   => $lesVisites
);
}
else{
    $tableau=array(
        "ok"   => true,
        "message"   => "aucune visites"
    );
}
echo json_encode($tableau);
