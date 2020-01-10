
window.TestFunctions = {
    InvokeAlert: function (AlertString) {
        alert(AlertString);
    }
};

function LastDiv() {
    $("div[class=divs]").hide();
    $("div[id=div4]").hide();
    number -= 1;
    var n = number.toString();
    $("div[id=div" + n + "]").removeClass('CHidden');
    $("div[id=div" + n + "]").show();

}
var number = 1;
function NextDiv() {
    $("div[class=divs]").hide();
    $("div[id=div4]").hide();
    number += 1;

    var n = number.toString();
    $("div[id=div"+n+"]").removeClass('CHidden');
    $("div[id=div" + n + "]").show();

}
function datumprikker() {
    var SelectedDates = {};
    SelectedDates[new Date('04/05/2019')] = new Date('04/05/2016');
    SelectedDates[new Date('05/04/2017')] = new Date('05/04/2017');
    SelectedDates[new Date('06/06/2018')] = new Date('06/06/2018');
    var nowDate = new Date();
    var today = new Date(nowDate.getFullYear(), nowDate.getMonth(), nowDate.getDate(), 0, 0, 0, 0);

    $('.input-daterange').datepicker({
        format: "mm/dd/yyyy",
        startDate: new Date(),
        numberOfMonths: 2,
        language: 'nl'

    });

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