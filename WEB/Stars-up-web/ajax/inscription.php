<?php

include_once('../class/mypdo.class.php');
$vpdo=new mypdo();
if(isset($_REQUEST['login']) && isset($_REQUEST['pass']) && isset($_REQUEST['nom']) && isset($_REQUEST['prenom']))
{
    $tab=array(
        "login"   => $_REQUEST['login'],
        "pass"   => sha1($_REQUEST['pass']),
        "nom" => $_REQUEST['nom'],
        "prenom" => $_REQUEST['prenom'],
        "type" => "gerant",
    );
    $result=$vpdo->connect($tab);
    if($result==null)
    {
        $res=$vpdo->inscription($tab);
        if($res==true)
        {
            $tableau=array(
                "ok"   => true,
                "message"   => "Inscription réussi"
            );
        }
        else
        {
            $tableau=array(
                "ok"   => false,
                "message"   => "Echec lors de l'inscription"
            );
        }

    }
    else
    {
        $tableau=array(
            "ok"   => false,
            "message"   => "Ce compte existe déja"
        );
    }
    echo json_encode($tableau);

}
