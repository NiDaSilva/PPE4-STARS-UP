var agenda= {
    lesdemandes: undefined,
    lesvisites: undefined,

    get_visites: function () {
        $.ajax({
            url: "../ajax/get_visites.php",
            type: "POST",
            async:false
        }).done(function (data) {
            data = JSON.parse(data);
            agenda.lesvisites=data.visites;
        });
        $.ajax({
            url: "../ajax/get_demandes.php",
            type: "POST",
            async: false
        }).done(function (data) {
            data = JSON.parse(data);
            agenda.lesdemandes=data.demandes;
        });
    },

    update_visite: function ($id,$date) {
        $.ajax({
            url: "../ajax/update_visite.php",
            type: "POST",
            data: ({id: $id, date:$date})
        }).done(function (data) {
            data = JSON.parse(data);
            agenda.lesvisites=data.visites;
            $(".fc-event[data-id="+$id+"]").remove();
        });
    }

}
