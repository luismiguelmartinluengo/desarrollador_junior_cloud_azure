using System;
using prueba;

namespace pruebaTest;

[TestClass]
public class KatasTest
{
    [TestMethod]
    public void JuegoMultiplosMultiplo3ReturnFizz()
    {
        Katas katas = new Katas();
        int numero = 9;
        string expectedResult = "Fizz";

        string result = katas.JuegoMultiplos(numero);

        Assert.AreEqual(expectedResult, result);
    }//End JuegoMultiplos

    [TestMethod]
    public void JuegoMultiplosMultiplo5ReturnBuzz()
    {
        Katas katas = new Katas();
        int numero = 10;
        string expectedResult = "Buzz";

        string result = katas.JuegoMultiplos(numero);

        Assert.AreEqual(expectedResult, result);
    }//End JuegoMultiplos

    [TestMethod]
    public void JuegoMultiplosMultiplo3y5ReturnBuzz()
    {
        Katas katas = new Katas();
        int numero = 15;
        string expectedResult = "FizzBuzz";

        string result = katas.JuegoMultiplos(numero);

        Assert.AreEqual(expectedResult, result);
    }//End JuegoMultiplos

    [TestMethod]
    public void JuegoMultiplosNoMultiploReturnNumberAsString()
    {
        Katas katas = new Katas();
        int numero = 4;
        string expectedResult = "4";

        string result = katas.JuegoMultiplos(numero);

        Assert.AreEqual(expectedResult, result);
    }//End JuegoMultiplos
    [TestMethod]
    public void JuegoMultiplosMultiplo7ReturnTazz()
    {
        Katas katas = new Katas();
        int numero = 14;
        string expectedResult = "Tazz";

        string result = katas.JuegoMultiplos(numero);

        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void JuegoMultiplosMultiplo3y7ReturnFizzTazz()
    {
        Katas katas = new Katas();
        int numero = 21;
        string expectedResult = "FizzTazz";

        string result = katas.JuegoMultiplos(numero);

        Assert.AreEqual(expectedResult, result);
    }


    [TestMethod]
    public void JuegoMultiplosIsRecursivePrime()
    {
        Katas katas = new Katas();
        int numero = 47;
        int divisor = 3;
        bool expectedResult = true;

        bool result = katas.EsPrimoRecursivo(numero, divisor);

        Assert.AreEqual(expectedResult, result);
    }



    [TestMethod]
    public void JuegoMultiplosIsPrime()
    {
        Katas katas = new Katas();
        int numero = 11;
        bool expectedResult = true;

        bool result = katas.EsPrimo(numero);

        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void JuegoMultiplosPrimeNumber()
    {
        Katas katas = new Katas();
        int numero1 = 11;
        int numero2 = 23;
        int numero3 = 47;
        string expectedResult = "Primo";

        string result1 = katas.JuegoMultiplos(numero1);
        string result2 = katas.JuegoMultiplos(numero2);
        string result3 = katas.JuegoMultiplos(numero3);

        Assert.AreEqual(expectedResult, result1);
        Assert.AreEqual(expectedResult, result2);
        Assert.AreEqual(expectedResult, result3);
    }



}//End KatasTest
