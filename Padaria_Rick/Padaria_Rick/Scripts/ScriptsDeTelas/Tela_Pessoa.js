$(document).ready(function () {
    $("#cpf").mask("999.999.999-99");
});

$("#nome").keyup(function () {
    var valor = $("#nome").val().replace(/[^a-zA-Z " "]+/g, '');
    $("#nome").val(valor);
});

