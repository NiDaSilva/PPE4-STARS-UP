<?php

$response = array();    // array for JSON response

require_once __DIR__ . '/db_connect.php';   // include db connect class

$db = new DB_CONNECT(); // connecting to db

// check for post data
if (isset($_GET["id"])) {
    $id = $_GET['id'];

//ID_VISITE,v.ID_HEBERGEMENT,ID_SAISON,DATE_HEURE_VISITE, NOM_HEBERGEMENT,ADRESSE_HEBERGEMENT,VILLE_HEBERGEMENT,ID_DEPARTEMENT,HORAIRES  WHERE ID_INSPECTEUR = $id

    // get a visite from visites table
    $result = mysql_query("SELECT * FROM visiter AS v INNER JOIN hebergement AS h ON v.ID_HEBERGEMENT=h.ID_HEBERGEMENT WHERE 1 ") or die(mysql_error());

    if (!empty($result)) {
        // check for empty result
        if (mysql_num_rows($result) > 0) {

            // user node
            $response["visite"] = array();
 
            while ($row = mysql_fetch_array($result)) {
                // temp user array
                $visite = array();
                $visite["id"]           = $row["ID_VISITE"];
                $visite["id_h"]         = $row["ID_HEBERGEMENT"];
                $visite["id_s"]         = $row["ID_SAISON"];
                $visite["date"]         = $row["DATE_HEURE_VISITE"];
                $visite["nom"]          = $row["NOM_HEBERGEMENT"];
                $visite["adresse"]      = $row["ADRESSE_HEBERGEMENT"];
                $visite["ville"]        = $row["VILLE_HEBERGEMENT"];
                $visite["departement"]  = $row["ID_DEPARTEMENT"];
                $visite["horaires"]     = $row["HORAIRES"];
         
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