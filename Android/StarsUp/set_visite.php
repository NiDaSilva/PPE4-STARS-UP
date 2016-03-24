<?php

$response = array();    // array for JSON response
 
// check for required fields
if (isset($_GET['id']) && isset($_GET['note']) && isset($_GET['commentaire']) ) {
 
    $id = $_GET['id'];
    $note = $_GET['note'];
    $commentaire = $_GET['commentaire'];
 
    // include db connect class
    require_once __DIR__ . '/db_connect.php';
 
    // connecting to db
    $db = new DB_CONNECT();
 
    // mysql update row with matched pid
    $result = mysql_query("UPDATE visiter SET NOMBRE_ETOILE_VISITE = $note, COMMENTAIRE_VISITE = $commentaire WHERE ID_VISITE = $id");
 
    // check if row inserted or not
    if ($result) {
        // successfully updated
        $response["success"] = 1;
        $response["message"] = "Visite enregistrée";
 
        // echoing JSON response
        echo json_encode($response);
    }
    else {
        $response["success"] = 1;
        $response["message"] = "Erreur";
 
        // echoing JSON response
        echo json_encode($response);

    }
} 
else {
    // required field is missing
    $response["success"] = 0;
    $response["message"] = "Il manque des champs";
 
    // echoing JSON response
    echo json_encode($response);
}
?>