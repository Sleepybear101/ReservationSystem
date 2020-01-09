
function CreateAlert() {
    $("div[id=div2").removeClass('CHidden');
    $("div[id=div1").hide();



}
function NextDiv(){
    $("div[class=divs]").hide();
    var number = 2
    number += 1;
    var n = number.toString();
    $("div[id=div"+n+"]").show();
}