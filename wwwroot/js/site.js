function IngresarLetra(letra, palabra) {

    const letras = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"];
    //Seguramente hay una mejor manera de hacer esto

    letra = letra.toLowerCase();

    if (letras.includes(letra)) {

        let l = document.getElementById(letra)
        
        if (l.style.color == "red") {

            return false
        }

        if (palabra.includes(letra)) {
            l.style.color = "green"

            for (let i = 0; i < palabra.length; i++) {

                if (palabra[i] === letra) {

                    let letraElemento = document.getElementById("letra" + i);
                    letraElemento.textContent = letra;
                }

                }

            return true
        }
        
        l.style.color = "red"

    }
}

function IngresarPalabra(palabra, pCompleta)
{
    let c

    if (palabra.toLowerCase() === pCompleta)
    {
        c = true;
    }
    else
    {
        c = false;
    }

    return c;

}

function IngresarPalabra(arriesgo, palabra){
    if(arriesgo === palabra)
    return true
    else
    return false
}

