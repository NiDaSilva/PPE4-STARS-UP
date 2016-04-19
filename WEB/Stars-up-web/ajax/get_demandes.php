<?php
$lesDemandes = array();
$i = 0;
include_once('../class/mypdo.class.php');
$vpdo = new mypdo();
session_start();
$id = $_SESSION["id"];
$result = $vpdo->get_demandes($id);
if ($result) {
    foreach ($result as $r) {
        $lesDemandes[$i] = array(
            "id" => $r["IDV"],
            "title" => $r["NOM"]
        );
        $i++;
    }
    $tableau = array(
        "ok" => true,
        "demandes" => $lesDemandes
    );
}
else
{
    $tableau = array(
        "ok" => true,
        "message" => "aucune demande"
    );
}
echo json_encode($tableau);
