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
$("#signin").click(function(){
    $.ajax({
        url: "../ajax/connect.php",
        type: "POST",
        data: ({login : $("#login").val(),pass : $("#password").val(),type : $("#choix li.active").text().toLowerCase()})
    }).done(function(data)
    {
        data=JSON.parse(data);
       if(data.ok==true)
       {
           alert("ça marche !il es connecter on fera un petit affichage des familles ici");
       }
        else
       {
           alert("ça marche ! il est nul on fera un petit affichage des familles ici");
       }
    });
});
</script>