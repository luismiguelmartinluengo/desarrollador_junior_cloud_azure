using System;

namespace pruebaTest;

[TestClass]
public class ScoringBowlingTest
{
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
    }//End TestMethod


}
