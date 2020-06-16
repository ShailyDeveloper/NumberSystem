function CheckValue() {
    var Value = $('.txtNum').val();
    var letterNumber = /\d{0,26}?\.?\d{0,26}$/g
    if ((Value.match(letterNumber))) {
        $("input[id=hdnfldErrorOutput]").val("False")
    }
    else {
        $("input[id=hdnfldErrorOutput]").val("True")
    }
}

function allowOnlyNumber(evt) {
    var charCode = (evt.which) ? evt.which : event.keyCode
    if (charCode != 46 && charCode > 31 && (charCode < 48 || charCode > 57))
        return false;
    return true;
}

