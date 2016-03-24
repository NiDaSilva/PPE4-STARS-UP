<?php
include_once('../class/page_base.class.php');
include '../class/connexion.controller.class.php';

$controller = new conn_controller();

$connexion = new page_base('login');

$connexion->corps=$controller->corps_connexion();
    

$connexion->afficher();
?>
<script type="text/javascript">
$(".switch").click(function () {
	var li = '#li'+$(this).attr("name");	           
           $(".liconn").removeClass("active");
           $(li).addClass("active");

});
</script>