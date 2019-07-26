$(document).ready(function () {
    jQuery.noConflict();
    validaLetrasNome();
    $("#cpf").mask('000.000.000-00');


    
});

function validaLetrasNome() {
    $("#nome").keyup(function () {
		var valor = $("#nome").val().replace(/[^a-zA-Z " "]+/g, '');
        $("#nome").val(valor);
        
	});
}

function validaFormulario() {
    
    $("#form").validate();
}

        
function Excluir(id) {
    if (confirm("Deseja realmente excluir?") == true) {
        $.ajax({
            type: 'POST',
            dataType: 'json',
            cache: false,
            url: '/Pessoa/Excluir/',
            data: { id: id },
            complete:
                function validar(jqXHR, resposta) {
                    if (jqXHR.responseJSON == "Sim") {
                        $("#pessoa-" + id).html("");
                    } else {
                        alert("Erro ao excluir");
                    }
                },
            error: function (jqXHR, textStatus, errorThrown) {
                alert('Error - ' + errorThrown);
            }
        });
    }
    else {
        return false;
    }
}

function Editar(id) {
   
        $.ajax({
            type: 'POST',
            dataType: 'json',
            cache: false,
            url: '/Pessoa/Excluir/',
            data: { id: id },
            complete:
                function validar(jqXHR, resposta) {
                    if (jqXHR.responseJSON == "Sim") {
                        $("#pessoa-" + id).html("");
                    } else {
                        alert("Erro ao excluir");
                    }
                },
            error: function (jqXHR, textStatus, errorThrown) {
                alert('Error - ' + errorThrown);
            }
        });   
}
