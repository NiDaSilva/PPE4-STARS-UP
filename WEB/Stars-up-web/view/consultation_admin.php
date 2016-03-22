<?php
include_once('../class/page_base.class.php');
include '../class/admin.controller.class.php';

$controller = new admin_controller();

$test = new page_base('GESTION CRUD');

$test->corps=$controller->corps_admin();

$test->afficher();
?>

<script type="text/javascript">





$("#nomtable").change(function (){
    $.ajax({
        url: "../ajax/switch_tableau_bdd.php",
        type: "GET",
        data: ({table : $("#nomtable").val()}),

        success: function (data) {

           $("#resultajax").empty();
           var d = $.parseJSON(data)
           $("#resultajax").append(d);
        },
        error: function () {
            alert("fail");
        }
    })
});

$("#page").click(function (){
    $.ajax({
        url: "../ajax/switch_tableau_bdd.php",
        type: "GET",
        data: ({nbpage : $("#page").text()}),

        success: function (data) {

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
