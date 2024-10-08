using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace prueba;

public class Katas
{

    public bool EsPrimoRecursivo(int numero, int divisor)
    {
        if (divisor > Math.Sqrt(numero)) return true; // Si el divisor supera la raíz cuadrada, es primo
        if (numero % divisor == 0) return false; // Si es divisible por el divisor, no es primo

        // Llamada recursiva con el siguiente divisor impar
        return EsPrimoRecursivo(numero, divisor + 2);
    }

    public bool EsPrimo(int numero)
    {
        if (numero <= 1) return false; // Números menores o iguales a 1 no son primos
        if (numero == 2) return true; // 2 es primo
        if (numero % 2 == 0) return false; // Números pares mayores que 2 no son primos

        // Llamada recursiva
        return EsPrimoRecursivo(numero, 3);
    }

    public string JuegoMultiplos(int pNumero){

        string result = "";
        if (pNumero % 3 == 0){
            result += "Fizz";
        }//End if
        if (pNumero % 5 == 0){
            result += "Buzz";
        }//End if
        if (pNumero % 7 == 0){
            result += "Tazz";
        }//End if
        if (EsPrimo(pNumero)){
            result += "Primo";
        }
        return result.Length > 0? result : pNumero.ToString();
        /* Otra solucion 
        var result = (pNumero % 3 == 0 ? "Fizz" : "") + (pNumero % 5 == 0 ? "Buzz" : "") + (pNumero % 7 == 0 ? "Tazz" : "") ;
        return string.IsNullOrEmpty(result) ? pNumero.ToString() : result;
         */
    }//End JuegoMultiplos

}//End Katas
