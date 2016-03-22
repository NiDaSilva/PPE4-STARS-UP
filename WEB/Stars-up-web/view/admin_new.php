<?php
include_once('../class/page_base.class.php');
include '../class/admin.controller.class.php';

$controller = new admin_controller();

$new = new page_base('new '.$_GET['type']);

$new->corps=$controller->corps_new($_GET['type']);

$new->afficher();
?>



<script type="text/javascript">
$("#submit").click(function () {
	var params =     {  	departement : "nico aime la bite"
        }
    $.ajax({
        url: "../ajax/valid_ajout_hebergement.php",
        type: "GET",
        data :  params,

        success: function (data) {
        	$("#resultajax").append(data);
        	console.log(data);
        },
        error: function () {
            alert("fail");
        }
    })
});</script>

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