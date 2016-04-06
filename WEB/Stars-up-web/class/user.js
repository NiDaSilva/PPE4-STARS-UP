var user= {
    objetUser: undefined,


    connexion: function ($params) {
        $.ajax({
            url: "../ajax/connect.php",
            type: "POST",
            data: ({login: $params["login"], pass: $params["pass"], type: $params["type"]})
        }).done(function (data) {
            data = JSON.parse(data);
            if (data.ok == true) {
                $("#nul").hide();
                $("#bien").text(data.message).show();
                setTimeout( function(){
                    $("#bien").hide();
                    if (data.type == "gerant") {
                        document.location.href = "../index.php";
                    }
                }, 2000 );

            }
            else
            {
                $("#bien").hide();
                $("#nul").text(data.message).show();
            }
        });
    },
    inscription: function ($params) {
        $.ajax({
            url: "../ajax/inscription.php",
            type: "POST",
            data: ({nom: $params["nom"], prenom: $params["prenom"], login: $params["login"], pass: $params["pass"]})
        }).done(function (data) {
            data = JSON.parse(data);
            if (data.ok == true) {
                $("#nul").hide();
                $("#bien").text(data.message).show();
            }
            else {
                $("#nul").text(data.message).show();
            }
        });
    }
}
