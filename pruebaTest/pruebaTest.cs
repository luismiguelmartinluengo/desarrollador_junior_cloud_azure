namespace prueba;

[TestClass]
public class CalculadoraTest{
    [TestMethod]
    public void sum_5_8_result_13(){
        //Arange
        Calculadora calculadora = new Calculadora();
        int numberA = 5;
        int numberB = 8;
        int expectedResult = 13;
        //Act
        int result = calculadora.sum(numberA,numberB);
        //Assert
        Assert.AreEqual(expectedResult, result);
    }//End sum_5_8_result_13

    [TestMethod]
    public void subtraction_10_5_result_5(){
        //Arange
        Calculadora calculadora = new Calculadora();
        int numberA = 10;
        int numberB = 5;
        int expectedResult = 5;
        //Act
        int result = calculadora.subtraction(numberA,numberB);
        //Assert
        Assert.AreEqual(expectedResult, result);
    }//End subtraction_10_5_result_5

    [TestMethod]
    public void multiplication_4_9_result_36(){
        //Arange
        Calculadora calculadora = new Calculadora();
        int numberA = 4;
        int numberB = 9;
        int expectedResult = 36;
        //Act
        int result = calculadora.multiplication(numberA,numberB);
        //Assert
        Assert.AreEqual(expectedResult, result);
    }//End multiplication_4_9_result_36

    [TestMethod]
    public void division_20_4_result_5(){
        //Arange
        Calculadora calculadora = new Calculadora();
        int numberA = 20;
        int numberB = 4;
        int expectedResult = 5;
        //Act
        int result = calculadora.division(numberA,numberB);
        //Assert
        Assert.AreEqual(expectedResult, result);
    }//End sum_5_8_result_13



}//End CalculadoraTest