<?php
//envoi du formulaire hebergement.

include_once('../class/mypdo.class.php');
$vpdo=new mypdo();
$data = 'ECHEC';
if(isset($_REQUEST['login']) && isset($_REQUEST['pass']) && isset($_REQUEST['type']))
{
    $tab=array(
        "id"   => $_REQUEST['login'],
        "mp"   => $_REQUEST['pass'],
        "type" => $_REQUEST['type'],
    );
    $result=$vpdo->connect($tab);
    if($result!=null)
    {
        session_start();
        $_SESSION['id'] = $result['ID_INSPECTEUR'];
        $_SESSION['NOM'] = $result['NOM_INSPECTEUR'];
        $_SESSION['type'] = $_REQUEST['type'];
        $tableau=array(
            "ok"   => true,
            "message"   => "Vous êtes bien connecter"
        );
    }
    else
    {
        $tableau=array(
            "ok"   => false,
            "message"   => "Echec de la connection"
        );
    }
    echo json_encode($tableau);

}
?>