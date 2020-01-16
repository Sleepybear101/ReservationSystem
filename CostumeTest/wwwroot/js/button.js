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
    if (ClickedForm == 3) {
    $(".TableWitFour").removeClass('Disabled');
    $(".TableWitSix").removeClass('Disabled');
    $(".TableWitTwo").removeClass('Disabled');
    TableFiv = 0;
    TableSix = 0;
    $(".Tafel").removeClass('ReservedT');

    }
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
    } else if (Amount >= 2 && TableSix == 0) {
        $(".TableWitSix").addClass('Disabled');
        $(".TableWitFour").addClass('Disabled');
    } else if (Amount == 1) {
        $(".TableWitFour").addClass('Disabled');
        $(".TableWitSix").addClass('Disabled');
    } else if (Amount == 2 && TableSix  == 6 && TableFiv == 5) {
        $(".TableWitFour").removeClass('Disabled');
        $(".TableWitSix").addClass('Disabled');
    } else if (Amount >= 2 && TableFiv == 0) {
        $(".TableWitSix").addClass('Disabled');
        $(".TableWitFour").addClass('Disabled');
    } else if (Amount >= 2 && TableSix == 0 && TableFiv == 0) {
        $(".TableWitSix").addClass('Disabled');
        $(".TableWitFour").addClass('Disabled');
    }

  
}
var Table = 0;
var TableSix = 0;
var TableFiv = 0;

function DisabledReserved(Table) {
    if (Table == 6) {
        TableSix = 6;
        var Tan = Table.toString();
        $("button[id=Table" + Tan + "]").addClass('ReservedT');
      
            Disabled();
        
    } else if (Table == 5) {
        TableFiv = 5;
        var Tan = Table.toString();
        $("button[id=Table" + Tan + "]").addClass('ReservedT');
            Disabled();
        
    } else {
        var Tan = Table.toString();
        $("button[id=Table" + Tan + "]").addClass('ReservedT');
    }

}
var Onderwerp;
function Message(Onderwerp) {

    if (Onderwerp == "Succes") {
        $("#ReservationSucces").modal();

    } else if (Onderwerp == "Blocked") {
    $("#BlockedMessage").modal();

    } else if (Onderwerp == "Chosen") {
        $("#NotFilledOrChosenMessage").modal();
        $(".Amount").addClass('NotCorrect');
        
    } else if (Onderwerp == "Email") {
       $("#EmailNotMessage").modal();

    }

}
