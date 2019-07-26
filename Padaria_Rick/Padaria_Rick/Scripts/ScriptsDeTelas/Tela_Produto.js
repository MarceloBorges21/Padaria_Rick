$(document).ready(function () {
	var $JQuery = jQuery.noConflict();
	$("#Valor").maskMoney({ decimal: ",", thousands: "." });
	filtraBebida();
	filtraSalgado();
	filtraDoce();
});

function filtraBebida() {
	var campoFiltro = document.querySelector("#filtrar-bebida");

	campoFiltro.addEventListener("input", function () {
		var bebidas = document.querySelectorAll(".bebidas");
        console.log("AQUI");
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
			for (let i = 0; i < bebidas.length; i++) {
				var bebidass = bebidas[i];
				bebidass.classList.remove("invisivel");
			}
		}
	});
}

function filtraSalgado() {
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
			for (var I = 0; I < salgados.length; I++) {
				var salgadoss = salgados[I];
				salgadoss.classList.remove("invisivel");
			}
		}
	});
}

function filtraDoce() {
	var campoFiltro = document.querySelector("#filtrar-doce");

	campoFiltro.addEventListener("input", function () {
		var doces = document.querySelectorAll(".doces");

		if (this.value.length > 0) {
			for (var i = 0; i < doces.length; i++) {
				var doce = doces[i];
				var tdNome = doce.querySelector(".nomeDoce");
				var nome = tdNome.textContent;
				var expressao = new RegExp(this.value, "i");

				if (!expressao.test(nome)) {
					doce.classList.add("invisivel");
				} else {
					doce.classList.remove("invisivel");
				}
			}
		} else {
			for (var I = 0; I < doces.length; I++) {
				var docess = doces[i];
				docess.classList.remove("invisivel");
			}
		}
	});
}



