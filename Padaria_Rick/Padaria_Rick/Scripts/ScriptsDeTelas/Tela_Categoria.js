$(document).ready(function ($) {
	filtraBebida();
});

function filtraBebida() {
	var campoFiltro = document.querySelector("#filtrar-categoria");

	campoFiltro.addEventListener("input", function () {
		var bebidas = document.querySelectorAll(".categoria");

		if (this.value.length > 0) {
			for (var i = 0; i < bebidas.length; i++) {
				var bebida = bebidas[i];
				var tdNome = bebida.querySelector(".nomeCategoria");
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