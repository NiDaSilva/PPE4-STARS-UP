<?php
include_once('../class/page_base.class.php');
include '../class/admin.controller.class.php';

$controller = new admin_controller();

$update = new page_base('Update '.$_GET['type']);

$update->corps=$controller->corps_new($_GET['type']);

$update->afficher();
?>


<script type="text/javascript"> //submit inspecteur
$("#submitinspecteur").click(function(){
    $.ajax({
                url: "../ajax/valid_update_inspecteur.php",
                type: "GET",
                data: ({
                    id : $("#id").val(),
                    table : $("#table").val(),
                    specialite : $("#specialite").val(),
                    nom : $("#nom").val(),
                    prenom : $("#prenom").val(),
                    login : $("#login").val(),
                    password: $("#mdp").val()
                }),

                success: function (data) {
                    $("#alertsubmit").empty();
                    var d = $.parseJSON(data);
                   $("#alertsubmit").append(d);
                },
                error: function () {
                }
            })
});

$("#submitgerant").click(function(){
    $.ajax({
                url: "../ajax/valid_update_gerant.php",
                type: "GET",
                data: ({
                    id : $("#id").val(),
                    table : $("#table").val(),
                    nom : $("#nom").val(),
                    prenom : $("#prenom").val(),
                    login : $("#login").val(),
                    password: $("#mdp").val()
                }),

                success: function (data) {
                    $("#alertsubmit").empty();
                    var d = $.parseJSON(data);
                   $("#alertsubmit").append(d);
                },
                error: function () {
                }
            })
});

$("#submitvisite").click(function(){
    $.ajax({
                url: "../ajax/valid_update_visite.php",
                type: "GET",
                data: ({
                    id : $("#id").val(),
                    table : $("#table").val(),
                    hebergement : $("#hebergement").val(),
                    saison : $("#saison").val(),
                    annee : $("#annee").val()
                }),

                success: function (data) {
                    $("#alertsubmit").empty();
                    var d = $.parseJSON(data);
                   $("#alertsubmit").append(d);
                },
                error: function () {
                }
            })
});
</script>


<script type="text/javascript">
 $(document).ready(function() {
        $.ajax({
        url: "../ajax/get_item.php",
        type: "POST",
        data: ({table : $("#table").val(),
                id: $("#id").val()}) 
	    }).done(function(data){
            data = JSON.parse(data);

	    	if(data.table="inspecteur")
            {
	    		$("#specialite").prop("selectedIndex",data.id_specialite);
                $("#nom").val(data.nom);
                $("#prenom").val(data.prenom);
                $("#login").val(data.login);
                $("#mdp").val(data.mdp);
            }
        if(data.table="gerant")
            {
                $("#nom").val(data.nom);
                $("#prenom").val(data.prenom);
                $("#login").val(data.login);
                $("#mdp").val(data.mdp);
            }
        


	    })
    });
</script>



<script type="text/javascript">
$("#hotel").click(function () {
    $.ajax({
        url: "../ajax/switch_hebergement.php",
        type: "GET",
        data: {categ : "hotel"},

        success: function (data) {

           $("#lihotel").addClass("active");
           $("#lichambre").removeClass("active");
           $("#licamping").removeClass("active");
           $("#resultajax").empty();
           var d = $.parseJSON(data)
           $("#resultajax").append(d);
        },
        error: function () {
            alert("fail");
        }
    })
});
$("#camping").click(function () {
    $.ajax({
        url: "../ajax/switch_hebergement.php",
        type: "GET",
        data: {categ : "camping"},

        success: function (data) {

           $("#licamping").addClass("active");
           $("#lichambre").removeClass("active");
           $("#lihotel").removeClass("active");
           $("#resultajax").empty();
           var d = $.parseJSON(data)
           $("#resultajax").append(d);
        },
        error: function () {
            alert("fail");
        }
    })
});
$("#chambre").click(function () {

    $.ajax({
        url: "../ajax/switch_hebergement.php",
        type: "GET",
        data: {categ : "chambre"},

        success: function (data) {

           $("#lichambre").addClass("active");
           $("#lihotel").removeClass("active");
           $("#licamping").removeClass("active");
           $("#resultajax").empty();
           var d = $.parseJSON(data)
           $("#resultajax").append(d);
        },
        error: function () {
            alert("fail");
        }
    })
});
</script>