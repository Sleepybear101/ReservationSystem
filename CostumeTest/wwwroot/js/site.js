var number = 1;
var Amount = 0;

var Daypart;

var Table = 0;
var TableSix = 0;
var TableFiv = 0;

var Subject;

function ResetTables() {
    $(".Table-div").removeClass('CHidden');
    $(".TableWitFour").removeClass('Disabled');
    $(".TableWitSix").removeClass('Disabled');
    $(".TableWitTwo").removeClass('Disabled');
    TableFiv = 0;
    TableSix = 0;
    $(".Table").removeClass('ReservedT');
}

function ResetSteps() {
    $(".Daypart-btn").removeClass("Daypart-btn-after");
    $(".steps-circle").removeClass('btn-success');
    $(".steps-circle").addClass('btn-circle');
}

function HoldValue(Daypart) {
    $(".Daypart-btn").removeClass("Daypart-btn-after");
    if (Daypart == "Lunch") {
        $(".form-daypart-btn-lunch").addClass("Daypart-btn-after");
    } else {
        $(".form-daypart-btn-diner").addClass("Daypart-btn-after");
    }
}

//verstop de div's met class divs name en laat de eerste div zien
function LastDiv(ClickedForm) {
    $("div[class=divs]").hide();
    $("div[id=div4]").hide();
    var b = ClickedForm.toString();
    $("#Step" + b + "").removeClass('btn-success');
    $("#Step" + b + "").addClass('btn-circle');

    ClickedForm--;
    if (ClickedForm == 3) {
        $(".Daypart-btn").removeClass("Daypart-btn-after");
        $(".TableWitFour").removeClass('Disabled');
        $(".TableWitSix").removeClass('Disabled');
        $(".TableWitTwo").removeClass('Disabled');
        TableFiv = 0;
        TableSix = 0;
        $(".Tafel").removeClass('ReservedT');

    } else if (ClickedForm == 2) {
        $(".Daypart-btn").removeClass("Daypart-btn-after");
        $(".Daypart-btn").removeClass('Disabled');
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
    $("div[id=ButtonsProccess]").hide();
    var b = ClickedForm.toString();
    $("#Step" + b + "").removeClass('btn-progges');
    $("#Step" + b + "").addClass('btn-success');
    ClickedForm++;
    if (ClickedForm == 2) {
        $("div[id=ButtonsProccess]").removeClass('CHidden');
        $("div[id=ButtonsProccess]").show();
    }
    var n = ClickedForm.toString();
    $("div[id=div" + n + "]").removeClass('CHidden');
    $("div[id=div" + n + "]").show();
    $("#Step" + n + "").removeClass('btn-circle');
    $("#Step" + n + "").addClass('btn-progges');
    setDate();


}

//Zet de maximun en minum van de datum
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

//Blokkeerd de dagdeel van voorbijgaande tijd
function WhichDaypart(Daypart) {

    if (Daypart == "Lunch") {
        $(".form-daypart-btn-lunch").addClass('Disabled')
    } else if (Daypart == "Dinner") {
        $(".form-daypart-btn-diner").addClass('Disabled')
    }

}


//kijkt welke datum het is om de tafel indeling te veranderen
function WhichDate(CheckDate) {
    $(".table-setting").hide();
    var ValDatethis = new Date();
    var ValDateOne = new Date();
    var ValDateTwo = new Date();

    var ValYearTwo = ValDateTwo.getFullYear() + 2;
    var ValYearOne = ValDateOne.getFullYear() + 1;
    var ValYearThis = ValDatethis.getFullYear();

    ValDatethis = ValYearThis + '-' + 0 + 2 + '-' + 14;
    ValDateOne = ValYearOne + '-' + 0 + 2 + '-' + 14;
    ValDateTwo = ValYearTwo + '-' + 0 + 2 + '-' + 14;

    if (CheckDate == ValDatethis || CheckDate == ValDateOne || CheckDate == ValDateTwo) {
        $("div[id=Valday]").show();
        $("div[id=NormalDay]").hide();
    } else {
        $("div[id=NormalDay]").show();
        $("div[id=Valday]").hide();
    }
}

//Blokkeert tafels met minder stoelen dan aantal personen
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
    } else if (Amount == 2 && TableSix == 6 && TableFiv == 5) {
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

//Blokkeert tafels die gereserveerd zijn
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

//Toon melding die bij de onderwerp hoorts
function Message(Subject) {
    if (Subject == "Succes") {
        $("#ReserveringOpnieuw").modal();
        $("#ReservationSucces").modal();
    } else if (Subject == "Blocked") {
        $("#BlockedMessage").modal();

    } else if (Subject == "Chosen") {
        $("#NotFilledOrChosenMessage").modal();
        $(".Amount").addClass('NotCorrect');

    } else if (Subject == "Email") {
        $("#EmailNotMessage").modal();
    }
}
