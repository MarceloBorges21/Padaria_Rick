$(document).ready(function () {
    $.noConflict();
    validaLetrasNome();
    
    $("#cpf").mask('000.000.000-00');
    $("#cpfEdicao").mask('000.000.000-00');
    

    $("#Salvar").click(function ()
    {
        validaFormulario();
        Adicionar();
    });

    $("#formedita").click(function () {
        validaFormulario();
        Editar();
    });
});

function validaLetrasNome() {
    var idNome = $("#nome");
    idNome.keyup(function () {
        var valor = idNome.val().replace(/[^a-zA-Z " "]+/g, '');
        idNome.val(valor);      
    });

    var idNomeEdicao = $("#nomeEdicao");
    idNomeEdicao.keyup(function () {
        var valor = idNomeEdicao.val().replace(/[^a-zA-Z " "]+/g, '');
        idNomeEdicao.val(valor);
    });
}

function validaFormulario() {
    $("#novo form_novo").validate();
    $("#editar form_editar").validate();
}

function Adicionar() {
    debugger
    jQuery.ajax
        ({
            type: "POST",
            url: "/Pessoa/Salvar",
            dataType: "json",
            data:
            {
                Nome: $("#nome").val(),
                CPF: $("#cpf").val(),
                Endereco: $("#endereco").val(),
                Login: $("#login").val(),
                Senha: $("#senha").val()
            },
            success: function (data) { 
                setTimeout(function () {
                    $('#novo').modal('hide');
                    window.location.assign("/Pessoa/Index");
                }, 2000);
            },
            error: function (request, status, erro) {
                alert("Ouve um erro: " + erro);
            },
            complete: function (jqXHR, textStatus) { }
        });
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

function CarregaDados(Id) {
    $.ajax
        ({
            url: "/Pessoa/CarregaDados/" + Id,
            success: function (data) {              
                $("#idEdicao").val(data.Id);
                $("#nomeEdicao").val(data.Nome);
                $("#cpfEdicao").val(data.CPF);
                $("#enderecoEdicao").val(data.Endereco);
                $("#loginEdicao").val(data.Login);
                $("#senhaEdicao").val(data.Senha);
            }
        });
}

function Editar() {
   
    debugger
    jQuery.ajax
        ({
            type: "PUT",
            url: "/Pessoa/Editar",
            dataType: "json",
            data:  $("#form_editar").serialize() ,
            success: function (data) {
                setTimeout(function () {
                    $('#editar').modal('hide');
                    window.location.assign("/Pessoa/Index");
                }, 2000);

            },
            error: function (request, status, erro) {
                alert("Ocorreu um erro : " + erro);
            },
            complete: function (jqXHR, textStatus) { }//mostra oq vc quiser assim q finalizar tudo
        });
}