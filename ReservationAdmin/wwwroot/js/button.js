var Amount = 0;
var Table = 0;
var TableSix = 0;
var TableFiv = 0;

function ResetTables() {

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
function Message() {
    alert("Reservering is aangemaakt");
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