<?php
include_once('../class/page_base.class.php');
include '../class/admin.controller.class.php';

$controller = new admin_controller();

$new = new page_base('new '.$_GET['type']);

$new->corps=$controller->corps_new($_GET['type']);

$new->afficher();
?>
