<?php
include_once('../class/page_base.class.php');
include '../class/admin.controller.class.php';

$controller = new admin_controller();

$update = new page_base('Update '.$_GET['type']);

$update->corps=$controller->corps_new($_GET['type']);

$update->afficher();
?>

<script type="text/javascript">
 $(document).ready(function() {
        $.ajax({
        url: "../ajax/get_item.php",
        type: "POST",
        data: ({table : $("#table").val(),
                id: $("#id").val()}) 
	    }).done(function(data){
	    	//console.log(data);
	    	
	    		$("#specialite").prop("selectedIndex",data.id_specialite);
                $("#nom").val()=data.nom;
                $("#prenom").val(data.prenom);
                $("#login").val(data.login);
                $("#mdp").val(data.mdp);
	    	
	    })
    });
</script>