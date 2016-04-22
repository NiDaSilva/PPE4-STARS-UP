<?php
include_once('../class/page_base_inspecteur.class.php');
include '../class/agenda.controller.class.php';

$controller = new agen_controller();

$agenda = new page_base_inspecteur('Votre agenda');

$agenda->corps=$controller->corps_agenda();


$agenda->afficher();
?>
<script>
    $(document).ready(function() {
        agenda.get_visites();
        if(agenda.lesdemandes) {
            for(var i= 0; i < agenda.lesdemandes.length; i++)
            {
                $('#external-events').append("<div data-overlap='false'  data-id="+agenda.lesdemandes[i].id+" class='fc-event ui-draggable ui-draggable-handle'>"+agenda.lesdemandes[i].title+"</div>");
            }
        }
        $('#trash').droppable({
            over: function(event, ui) {
                ui.draggable.remove();
            }
        });
        $('#external-events .fc-event').each(function() {
            $(this).data('event', {
                id:$.trim($(this).data('id')),
                title: $.trim($(this).text()),
                stick: true
            });
            $(this).draggable({
                zIndex: 999,
                revert: true,
                revertDuration: 0
            });

        });
        $("#calendar").fullCalendar({
            droppable: true,
            lang: 'fr',
            defaultTimedEventDuration:'02:00:00',
            weekends: false,
            minTime: "08:00:00",
            eventDurationEditable: false,
            maxTime: "20:00:00",
            defaultView: "agendaWeek",
            editable: true,
            eventConstraint: {
                start: moment().format('YYYY-MM-DD'),
                end: '3000-01-01'
            },
            eventDrop: function(event) {
                agenda.update_visite(event.id,event.start.format());
            },
            eventAfterRender: function(event, element){
                $(element).css("margin","1");
            },
            eventReceive:function(event) {
                agenda.update_visite(event.id,event.start.format());
            },
            events: agenda.lesvisites

        });
        $(".fc-right").remove();
        $(".fc-divider").remove();
        $(".fc-day-grid").remove();
    });
</script>