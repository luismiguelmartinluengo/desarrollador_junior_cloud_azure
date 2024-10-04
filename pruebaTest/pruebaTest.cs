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
        int? result = calculadora.sum(numberA,numberB);
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
        int? result = calculadora.subtraction(numberA,numberB);
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
        int? result = calculadora.multiplication(numberA,numberB);
        //Assert
        Assert.AreEqual(expectedResult, result);
    }//End multiplication_4_9_result_36

    [TestMethod]
    public void division_rest_0(){
        //Arange
        Calculadora calculadora = new Calculadora();
        int numberA = 20;
        int numberB = 4;
        int expectedResult = 5;
        //Act
        double? result = calculadora.division(numberA,numberB);
        //Assert
        Assert.AreEqual(expectedResult, result);
    }//End division_resto_0

    [TestMethod]
    public void division_rest_non_0(){
        //Arange
        Calculadora calculadora = new Calculadora();
        int numberA = 5;
        int numberB = 2;
        double expectedResult = 2.5;
        //Act
        double? result = calculadora.division(numberA,numberB);
        //Assert
        Assert.AreEqual(expectedResult, result);
    }//End division_resto_0

    [TestMethod]
    public void division_by_0(){
        //Arange
        Calculadora calculadora = new Calculadora();
        int numberA = 60;
        int numberB = 0;
        double? expectedResult = null;
        //Act
        double? result = calculadora.division(numberA,numberB);
        //Assert
        Assert.AreEqual(expectedResult, result);
    }//End division_by_0

    [TestMethod]
    public void sum_2_mas_division_by_0(){
        //Arange
        Calculadora calculadora = new Calculadora();
        int sumando1 = 10;
        int dividendo = 6;
        int divisor = 0;
        double? expectedResult = null;
        //Act
        double? divisionResult = calculadora.division(dividendo, divisor);
        double? result = calculadora.sum(sumando1,(int?) divisionResult);
        //Assert
        Assert.AreEqual(expectedResult, result);
    }//End division_by_0

}//End CalculadoraTest