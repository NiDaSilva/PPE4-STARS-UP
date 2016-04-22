<?php

$response = array();    // array for JSON response

require_once __DIR__ . '/db_connect.php';   // include db connect class

$db = new DB_CONNECT(); // connecting to db

// check for post data
if (isset($_GET["login"]) && isset($_GET["mdp"])) {
    $login = $_GET['login'];
    $mdp = $_GET['mdp'];
    $mdp = sha1($mdp);

    // get a inspecteur from inspecteurs table
    $result = mysql_query("SELECT * FROM inspecteur WHERE LOGIN = '".$login."' AND MDP = '".$mdp."'") or die(mysql_error());

    if (!empty($result)) {
        // check for empty result
        if (mysql_num_rows($result) > 0) {

            $result = mysql_fetch_array($result);

            $inspecteur = array();
            $inspecteur["id"]       = $result["ID_INSPECTEUR"];
            $inspecteur["id_specialite"] = $result["ID_SPECIALITE"];
            $inspecteur["nom"]      = $result["NOM_INSPECTEUR"];
            $inspecteur["prenom"]   = $result["PERNOM_INSPECTEUR"];
            $inspecteur["login"]    = $result["LOGIN"];
            $inspecteur["mdp"]      = $result["MDP"];
            // success
            $response["success"] = 1;

            // user node
            $response["inspecteur"] = array();

            array_push($response["inspecteur"], $inspecteur);

            // echoing JSON response
            echo json_encode($response);
        } 
        else {
            // no inspecteur found
            $response["success"] = 0;
            $response["message"] = "Mauvais login ou mot de passe";

            // echo no users JSON
            echo json_encode($response);
        }
    } 
    else {
        // no inspecteur found
        $response["success"] = 0;
        $response["message"] = "Mauvais login ou mot de passe";

        // echo no users JSON
        echo json_encode($response);
    }
} 
else {
    // required field is missing
    $response["success"] = 0;
    $response["message"] = "Login ou mot de passe est manquant";

    // echoing JSON response
    echo json_encode($response);
}
?>