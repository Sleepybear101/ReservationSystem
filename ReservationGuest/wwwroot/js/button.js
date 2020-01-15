var number = 1;

//verstop de div's met class divs name en laat de eerste div zien
function LastDiv(ClickedForm) {
    $("div[class=divs]").hide();
    $("div[id=div4]").hide();

    ClickedForm--;
    var n = ClickedForm.toString();
    $("div[id=div" + n + "]").show();


}
//verstop de div's met class divs name en laat de volgende div zien
function NextDiv(ClickedForm) {
    $("div[class=divs]").hide();
    $("div[id=div4]").hide();
    ClickedForm++;
    var n = ClickedForm.toString();
    $("div[id=div" + n + "]").removeClass('CHidden');
    $("div[id=div" + n + "]").show();


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
var Amount = 0;
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
    alert("Reservering is aangemaakt");
}
function Blocked() {
    alert("Het blijkt dat je email waarmee je wilt reserveren is geblokkeerd. Bel de restaurant om een reservering te maken.");
}
function NotFilled() {
    alert("Niet alle velden zijn ingevoerd/gekozen");

}
function NotCorrect() {
    alert("Email niet correct ingevoerd");

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
