function IngresarLetra(letra, palabra) {

    const letras = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"];
    //Seguramente hay una mejor manera de hacer esto

    letra = letra.toLowerCase();

    if (letras.includes(letra)) {

        if (palabra.includes(letra)) {

            return LetrasAdivinadas;

        }

        Intentos++;

        LetrasUsadas.Add(letra);

        if (palabra.includes(letra)) {

            for (let i = 0; i < palabra.length; i++) {

                if (Palabra[i] == letra) {

                    LetrasAdivinadas[i] = letra;

                }

            }
        }
    }

           return LetrasAdivinadas;
}

