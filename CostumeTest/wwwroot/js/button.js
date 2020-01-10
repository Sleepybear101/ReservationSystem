
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
    $("div[id=div"+n+"]").removeClass('CHidden');
    $("div[id=div" + n + "]").show();
    var n = number.toString();
    if (number == 2) {
        datumprikker();
    }

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
