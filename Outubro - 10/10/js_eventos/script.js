function validar(elemento) {
    var erro = document.getElementById("erro");
    if (elemento.value == ""){
        alert("Campo não pode ficar vazio");
        elemento.style.backgroundColor = "red";
        elemento.style.color = "white";
        erro.innerHTML = "Campo Obrigatório!";
    } else if (elemento.value.length < 3) {
        alert("Texto deve ter ao menos 3 caracteres");
        elemento.style.backgroundColor = "red";
        elemento.style.color = "white";
        erro.innerHTML = "Texto deve ter ao menos 3 caracteres!";
    } else {
        elemento.style.backgroundColor = "White";
        elemento.style.color = "black";
        erro.innerHTML = "Tudo OK!";
    }
}