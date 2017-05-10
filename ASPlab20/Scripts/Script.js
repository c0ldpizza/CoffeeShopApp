$(document).ready(function () {
    $(".passwordText").hide();
    $(".password").mouseover(function () {
        $(this).children(".passwordText").show();

    }).mouseleave(function () {
        $(this).children(".passwordText").hide();
    });
});