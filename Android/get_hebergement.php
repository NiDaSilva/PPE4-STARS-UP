<?php

$response = array();    // array for JSON response

require_once __DIR__ . '/db_connect.php';   // include db connect class

$db = new DB_CONNECT(); // connecting to db

// check for post data
if (isset($_GET["id"])) {
    $id = $_GET['id'];

    // get a hebergement from hebergements table
    $result = mysql_query("SELECT * FROM hebergement WHERE ID_HEBERGEMENT = $id");

    if (!empty($result)) {
        // check for empty result
        if (mysql_num_rows($result) > 0) {

            $result = mysql_fetch_array($result);

            $hebergement = array();
            $hebergement["id"]          = $result["ID_HEBERGEMENT"];
            $hebergement["nom"]         = $result["NOM_HEBERGEMENT"];
            $hebergement["adresse"]     = $result["ADRESSE_HEBERGEMENT"];
            $hebergement["ville"]       = $result["VILLE_HEBERGEMENT"];
            $hebergement["departement"] = $result["ID_DEPARTEMENT"];
            $hebergement["horaires"]    = $result["HORAIRES"];
            // success
            $response["success"] = 1;

            // user node
            $response["hebergement"] = array();

            array_push($response["hebergement"], $hebergement);

            // echoing JSON response
            echo json_encode($response);
        } 
        else {
            // no hebergement found
            $response["success"] = 0;
            $response["message"] = "Pas d'hebergements trouvés";

            // echo no users JSON
            echo json_encode($response);
        }
    } 
    else {
        // no hebergement found
        $response["success"] = 0;
        $response["message"] = "Pas d'hebergements trouvés";

        // echo no users JSON
        echo json_encode($response);
    }
} 
else {
    // required field is missing
    $response["success"] = 0;
    $response["message"] = "L'id de l'hebergement est manquant";

    // echoing JSON response
    echo json_encode($response);
}
?>