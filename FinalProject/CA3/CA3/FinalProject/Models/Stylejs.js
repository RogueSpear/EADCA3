$(document).ready(function () {
    $("#test").hide().fadeIn("slow");
    $("#hi").hide();
    
    if ($('.form-group').val() == '') {
        $('.form-group').css('border-color', 'red');
    }
    else {
        $('.form-group').css('border-color', '');
    }


});

