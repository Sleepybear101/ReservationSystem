// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
$(document).ready(function () {
    $("div[class=divs]").hide();
    $("div[id=div1").show();
    function checkifEmpty() {
        if ($("[class=form-controls1]").is(':empty')) {
            $filled = false;
            console.WriteLine("niet helemaal ingevuld");
        } else {
            $filled = true;
            console.WriteLine("wel iets in");
        }
    }
    $("input[type=button][class=buttons]").click(function () {
        checkifEmpty();
        if (filled) {
            $("div[class=divs]").hide();
            $("div[id=div" + $(this).attr("id") + "]").show();
        }
    });
});