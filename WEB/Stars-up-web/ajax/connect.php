<?php

include_once('../class/mypdo.class.php');
$vpdo=new mypdo();
if(isset($_REQUEST["login"]) && isset($_REQUEST["pass"]) && isset($_REQUEST["type"]))
{
    $tab=array(
        "login"   => $_REQUEST["login"],
        "pass"   => sha1($_REQUEST["pass"]),
        "type" => $_REQUEST["type"],
    );
    $result=$vpdo->connect($tab);
    if($result!=null)
    {
        session_start();
        $_SESSION["type"] = $_REQUEST["type"];
        if($_REQUEST["type"]=="inspecteur")
        {
            
            $_SESSION["id"] = $result["ID_INSPECTEUR"];
            $_SESSION["nom"] = $result["NOM_INSPECTEUR"];
        }else if($_REQUEST["type"]=="gerant")
        {
            $_SESSION["id"] = $result["ID_GERANT"];
            $_SESSION["nom"] = $result["NOM_GERANT"];
        }else{
            $_SESSION["id"] = "Admin";
            $_SESSION["nom"] = "Admin";
        }

        $tableau=array(
            "ok"   => true,
            "message"   => "Vous êtes bien connecté",
            "type"   => $_SESSION["type"]
        );
    }
    else
    {
        $tableau=array(
            "ok"   => false,
            "message"   => "Mauvais identifiant"
        );
    }
    echo json_encode($tableau);

}
