<?php

$response = array();    // array for JSON response

require_once __DIR__ . '/db_connect.php';   // include db connect class

$db = new DB_CONNECT(); // connecting to db

// check for post data
if (isset($_GET["id"])) {
    $id = $_GET['id'];

    // get a visite from visites table
    $result = mysql_query("SELECT * FROM visiter WHERE ID_INSPECTEUR = $id") or die(mysql_error());

    if (!empty($result)) {
        // check for empty result
        if (mysql_num_rows($result) > 0) {

            // user node
            $response["visite"] = array();
 
            while ($row = mysql_fetch_array($result)) {
                // temp user array
                $visite = array();
                $visite["id"]   = $result["ID_VISITE"];
                $visite["id_h"] = $result["ID_HEBERGEMENT"];
                $visite["id_s"] = $result["ID_SAISON"];
                $visite["date"] = $result["DATE_HEURE_VISITE"];
         
                // push single product into final response array
                array_push($response["visite"], $visite);
            }

            // success
            $response["success"] = 1;

            // echoing JSON response
            echo json_encode($response);
        } 
        else {
            // no visite found
            $response["success"] = 0;
            $response["message"] = "Pas de visites trouvées";

            // echo no users JSON
            echo json_encode($response);
        }
    } 
    else {
        // no visite found
        $response["success"] = 0;
        $response["message"] = "Pas de visites trouvées";

        // echo no users JSON
        echo json_encode($response);
    }
} 
else {
    // required field is missing
    $response["success"] = 0;
    $response["message"] = "L'id de l'inspecteur est manquant";

    // echoing JSON response
    echo json_encode($response);
}
?>