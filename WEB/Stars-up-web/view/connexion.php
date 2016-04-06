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
    if($("#login").val()!=""  && $("#password").val()!="" && $("#choix li.active").text().toLowerCase()!="") {
        user.connexion({
            login: $("#login").val(), pass: $("#password").val(), type: $("#choix li.active").text().toLowerCase()
        });
    }else
    {
        $("#nul").text("veuillez remplir tout les champs");
        $("#nul").show();
    }
});
$("#signup").click(function(){

    if($("#nom").val()!="" && $("#prenom").val()!="" && $("#user").val()!="" && $("#pass").val()!="")
    {
        user.inscription({nom: $("#nom").val(), prenom: $("#prenom").val(), login: $("#user").val(), pass: $("#pass").val()});
    }else
    {
        $("#nul").text("veuillez remplir tout les champs");
        $("#nul").show();
    }


});
</script>