$(document).ready(function () {
	var $JQuery = jQuery.noConflict();
	$("#cpf").mask("999.999.999-99");
	letrasNome();
});

function letrasNome() {
	$("#nome").keyup(function () {
		var valor = $("#nome").val().replace(/[^a-zA-Z " "]+/g, '');
		$("#nome").val(valor);
	});
}


