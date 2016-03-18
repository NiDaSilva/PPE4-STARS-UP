<?php
 
// A class file to connect to database

class DB_CONNECT {
 
    // constructor
    function __construct() {
        // connecting to database
        $this->connect();
    }
 
    // destructor
    function __destruct() {
        // closing db connection
        $this->close();
    }

    function connect() {

        define('DB_USER', "root"); // db user
        define('DB_PASSWORD', ""); // db password (mention your db password here)
        define('DB_DATABASE', "ppe4"); // database name
        define('DB_SERVER', "192.168.215.10"); // db server
 
        // Connecting to mysql database
        $con = mysql_connect(DB_SERVER, DB_USER, DB_PASSWORD) or die(mysql_error());
 
        // Selecing database
        $db = mysql_select_db(DB_DATABASE) or die(mysql_error()) or die(mysql_error());
 
        // returing connection cursor
        return $con;
    }
 
    function close() { // closing db connection
        mysql_close();
    }
    
}
 
?>