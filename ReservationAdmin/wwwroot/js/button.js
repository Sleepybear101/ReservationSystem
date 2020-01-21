var Amount = 0;
var Table = 0;
var TableSix = 0;
var TableFiv = 0;
var Daypart;
function HideTables() {
    $(".Table-div").addClass('CHidden');
    $(".Daypart-btn").removeClass("Daypart-btn-after");
}

function HoldValue(Daypart) {

    $(".Daypart-btn").removeClass("Daypart-btn-after");

    if (Daypart == "Lunch") {
        $(".Daypart-btn-lunch").addClass("Daypart-btn-after");

    } else {
        $(".Daypart-btn-diner").addClass("Daypart-btn-after");

    }
}

function ResetTables() {
        $(".Table-div").removeClass('CHidden');
        $(".TableWitFour").removeClass('Disabled');
        $(".TableWitSix").removeClass('Disabled');
        $(".TableWitTwo").removeClass('Disabled');
        TableFiv = 0;
        TableSix = 0;
       $(".Table").removeClass('ReservedT');
}
  
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


function Disabled(Amount) {

    if (Amount == 6) {
        $(".TableWitTwo").addClass('Disabled');
        $(".TableWitFour").addClass('Disabled');
    } else if (Amount >= 3  ) {
        $(".TableWitTwo").addClass('Disabled');
        $(".TableWitSix").addClass('Disabled');
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

function WhichDate(CheckDate) {
    $(".Table-div").removeClass('CHidden');
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
      $("button[id=Table"+Tan+"]").addClass('ReservedT');
    }
 
    
}
