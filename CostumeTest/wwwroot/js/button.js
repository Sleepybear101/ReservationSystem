var number = 1;

//verstop de div's met class divs name en laat de eerste div zien
function LastDiv() { 
    $("div[class=divs]").hide();
    $("div[id=div1]").show();
    number = 1
}
//verstop de div's met class divs name en laat de volgende div zien
function NextDiv() {
    $("div[class=divs]").hide();
    $("div[id=div4]").hide();
    number += 1;
    var n = number.toString();
    $("div[id=div"+n+"]").removeClass('CHidden');
    $("div[id=div"+n+"]").show();


    var dtToday = new Date();

    var month = dtToday.getMonth() + 1;
    var day = dtToday.getDate();
    var year = dtToday.getFullYear();
    if (month < 10)
        month = '0' + month.toString();
    if (day < 10)
        day = '0' + day.toString();

    var maxDate = year + '-' + month + '-' + day;
    $('#txtDate').attr('min', maxDate);



}


function Message() {
    alert("Reservering is aangemaakt");
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
