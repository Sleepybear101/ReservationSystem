﻿var Amount = 0;
var Table = 0;
var TableSix = 0;
var TableFiv = 0;
var Daypart;
var Subject;

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

function Message(Subject) {

    if (Subject == "Succes") {
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
    $("div[id=NormalDay]").addClass('NormalTable');
    $("div[id=NormalDay]").removeClass('Table-place')
        ;
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
        $("button[id=Table" + Tan + "]").addClass('ReservedT');
    }


}

function MonthSelector(Subject) {

    if (Subject == "Vis") {
        $(".SelectorMonth").removeClass('CHidden');

    } else {
        $(".SelectorMonth").addClass('CHidden');
    }
}