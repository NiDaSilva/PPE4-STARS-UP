<?php
include_once('../class/page_base.class.php');
include '../class/admin.controller.class.php';
if(!isset($_GET['page']))
{
$_GET['page']=1;
}
$controller = new admin_controller();

$test = new page_base('TEST');

$test->corps=$controller->corps_admin();

$test->afficher();
?>
