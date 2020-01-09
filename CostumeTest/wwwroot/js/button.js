var number = 2

function CreateAlert() {
    $("div[id=div1").hide();
    var n = number.toString();
    $("div[id=div"+n).removeClass('CHidden');



}

function NextDiv(){
    $("div[class=divs]").hide();
    number = 3;
    var n = number.toString();
    $("div[id=div"+n).removeClass('CHidden');
    $("div[id=div"+n+"]").show();
}