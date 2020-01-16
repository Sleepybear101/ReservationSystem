var number = 1;
var Amount = 0;

//verstop de div's met class divs name en laat de eerste div zien
function LastDiv(ClickedForm) {
    $("div[class=divs]").hide();
    $("div[id=div4]").hide();
    var b = ClickedForm.toString();
    $("#Step" + b + "").removeClass('btn-success');
    $("#Step" + b + "").addClass('btn-circle');
    ClickedForm--;
    var n = ClickedForm.toString();
    $("div[id=div" + n + "]").show();
    $("#Step" + n + "").removeClass('btn-success');
    $("#Step" + n + "").addClass('btn-progges');


}
//verstop de div's met class divs name en laat de volgende div zien
function NextDiv(ClickedForm) {
    $(".divs").hide();
    $("div[id=div4]").hide();
    var b = ClickedForm.toString();
    $("#Step" + b + "").removeClass('btn-progges');
    $("#Step"+b+"").addClass('btn-success');
    ClickedForm++;
    var n = ClickedForm.toString();
    $("div[id=div" + n + "]").removeClass('CHidden');
    $("div[id=div" + n + "]").show();
    $("#Step" + n + "").removeClass('btn-circle');
    $("#Step"+n+"").addClass('btn-progges');

    setDate();


}
function setDate() {


    var dtToday = new Date();

    var month = dtToday.getMonth() + 1;
    var day = dtToday.getDate();
    var year = dtToday.getFullYear();
    if (month < 10)
        month = '0' + month.toString();
    if (day < 10)
        day = '0' + day.toString();

    var today = new Date();
    var dd = today.getDate();
    var mm = today.getMonth() + 1;
    var yyyy = today.getFullYear() + 2;
    if (dd < 10) {
        dd = '0' + dd
    }
    if (mm < 10) {
        mm = '0' + mm
    }
    today = yyyy + '-' + mm + '-' + dd;
    var maxDate = year + '-' + month + '-' + day;
    $('#txtDate').attr('min', maxDate);
    $('#txtDate').attr('max', today);

}

function Disabled(Amount) {
    if (Amount == 6) {
        $(".TableWitTwo").addClass('Disabled');
        $(".TableWitFour").addClass('Disabled');
    } else if (Amount >= 4) {
        $(".TableWitTwo").addClass('Disabled');
    } else if (Amount >= 2) {
        $(".TableWitSix").addClass('Disabled');
    } else if (Amount == 1) {
        $(".TableWitFour").addClass('Disabled');
        $(".TableWitSix").addClass('Disabled');
    }


}
var Table = 0;
function DisabledReserved(Table) {
    var Tan = Table.toString();
    $("button[id=Table" + Tan + "]").addClass('ReservedT');
}
function Message() {
    ReservationSucces
    $("#ReservationSucces").modal();

}
function Blocked() {

    $("#BlockedMessage").modal();

}
function NotFilled() {
    $("#NotFilledOrChosenMessage").modal();

}
function NotCorrect() {
    $("#EmailNotMessage").modal();


}
/*
function datumprikker() {

    function() {
        $('#datetimepicker').datetimepicker({
            inline: true,
            sideBySide: true
        });
    }

        $('#datetimepicker').on('dp.change', function (event) {
            //console.log(moment(event.date).format('MM/DD/YYYY h:mm a'));
            //console.log(event.date.format('MM/DD/YYYY h:mm a'));
            $('#selected-date').text(event.date);
            var formatted_date = event.date.format('MM/DD/YYYY h:mm a');
            $('#my_hidden_input').val(formatted_date);
            $('#hidden-val').text($('#my_hidden_input').val());
        });

    NextDiv();

}
*/
