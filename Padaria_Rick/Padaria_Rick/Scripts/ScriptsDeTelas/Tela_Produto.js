$(document).ready(function ($) {
	$("#Valor").maskMoney({ decimal: ",", thousands: "." });
});

var campoFiltro = document.querySelector("#filtrar-bebida");

campoFiltro.addEventListener("input", function () {
    var bebidas = document.querySelectorAll(".bebidas");

    if (this.value.length > 0) {
        for (var i = 0; i < bebidas.length; i++) {
            var bebida = bebidas[i];
            var tdNome = bebida.querySelector(".nomeBebida");
            var nome = tdNome.textContent;
            var expressao = new RegExp(this.value, "i");

            if (!expressao.test(nome)) {
                bebida.classList.add("invisivel");
            } else {
                bebida.classList.remove("invisivel");
            }
        }
    } else {
        for (var i = 0; i < bebidas.length; i++) {
            var bebida = bebidas[i];
            bebida.classList.remove("invisivel");
        }
    }
});

var campoFiltro = document.querySelector("#filtrar-salgado");

campoFiltro.addEventListener("input", function () {
    var salgados = document.querySelectorAll(".salgados");

    if (this.value.length > 0) {
        for (var i = 0; i < salgados.length; i++) {
            var salgado = salgados[i];
            var tdNome = salgado.querySelector(".nomeSalgado");
            var nome = tdNome.textContent;
            var expressao = new RegExp(this.value, "i");

            if (!expressao.test(nome)) {
                salgado.classList.add("invisivel");
            } else {
                salgado.classList.remove("invisivel");
            }
        }
    } else {
        for (var i = 0; i < salgados.length; i++) {
            var salgado = salgados[i];
            salgado.classList.remove("invisivel");
        }
    }
});

var campoFiltro = document.querySelector("#filtrar-doce");

campoFiltro.addEventListener("input", function () {
    var pacientes = document.querySelectorAll(".doces");

    if (this.value.length > 0) {
        for (var i = 0; i < pacientes.length; i++) {
            var paciente = pacientes[i];
            var tdNome = paciente.querySelector(".nomeDoce");
            var nome = tdNome.textContent;
            var expressao = new RegExp(this.value, "i");

            if (!expressao.test(nome)) {
                paciente.classList.add("invisivel");
            } else {
                paciente.classList.remove("invisivel");
            }
        }
    } else {
        for (var i = 0; i < pacientes.length; i++) {
            var paciente = pacientes[i];
            paciente.classList.remove("invisivel");
        }
    }
});




