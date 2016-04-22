<?php
include_once('../class/page_base_gerant.class.php');
include '../class/admin.controller.class.php';

$controller = new admin_controller();

$new = new page_base_gerant('Demande visite');

$new->corps=$controller->corps_gerantvisite();

$new->afficher();
?>

<script type="text/javascript"> //submit inspecteur
$("#submitinspecteur").click(function(){
    $.ajax({
                url: "../ajax/valid_ajout_inspecteur.php",
                type: "GET",
                data: ({

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
                    $("#specialite").prop("selectedIndex",0);
                    $("#nom").val("");
                    $("#prenom").val("");
                    $("#login").val("");
                    $("#mdp").val("");
                },
                error: function () {
                }
            })
});

$("#submitgerant").click(function(){
    $.ajax({
                url: "../ajax/valid_ajout_gerant.php",
                type: "GET",
                data: ({

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
                    $("#nom").val("");
                    $("#prenom").val("");
                    $("#login").val("");
                    $("#mdp").val("");
                },
                error: function () {
                }
            })
});

$("#submitvisite").click(function(){
    $.ajax({
                url: "../ajax/valid_ajout_visite.php",
                type: "GET",
                data: ({
                    table : $("#table").val(),
                    hebergement : $("#hebergement").val(),
                    saison : $("#saison").val(),
                    annee : $("#annee").val()
                }),

                success: function (data) {
                    $("#alertsubmit").empty();
                    var d = $.parseJSON(data);
                   $("#alertsubmit").append(d);
                    $("#hebergement").prop("selectedIndex",0);
                    $("#saison").prop("selectedIndex",0);
                    $("#annee").prop("selectedIndex",0);
                },
                error: function () {
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

$(document).ready(function() {
        $(".hidenew").hide();
        });
</script>