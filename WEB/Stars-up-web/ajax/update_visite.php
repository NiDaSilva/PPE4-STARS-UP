<?php
$lesVisites = array();
$i = 0;
include_once('../class/mypdo.class.php');
$vpdo = new mypdo();
if (isset($_REQUEST["id"]) && isset($_REQUEST["date"])) {
    session_start();
    $id = $_SESSION["id"];
    $tab = array(
        "id" => $id,
        "idv" => $_REQUEST["id"],
        "date" => $_REQUEST["date"],
        "table" => "visiter"
    );
    $vpdo->update($tab);
    $tableau = array(
        "ok" => true);
} else {
    $tableau = array("ok" => false);
}
echo json_encode($tableau);
