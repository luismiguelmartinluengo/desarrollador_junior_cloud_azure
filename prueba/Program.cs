var firstNumber = 113;
var secondNumber = 7;
Console.WriteLine(firstNumber+secondNumber);

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine($"{firstName} sold {widgetsSold + firstNumber} widgets.");

int GetSum(int _fistNumber, int _secondNumber){
    return _fistNumber + _secondNumber;
}//End GetSum

int GetSubtraction(int _fistNumber, int _secondNumber){
    return _fistNumber - _secondNumber;
}//End GetSubtraction

int GetMultiplication(int _fistNumber, int _secondNumber){
    return _fistNumber * _secondNumber;
}//End GetSubtraction

object GetDivision(int _firstNumber, int _secondNumber, bool _asDecimal){
    object vReturn;
    if (_asDecimal){
        vReturn = _firstNumber * 1.0 / _secondNumber;
    }else {
        vReturn =  _firstNumber / _secondNumber;
    }//End if
    return vReturn;
}//End GetDivsion

int GetMod(int _firstNumber, int _secondNumber){
    return _firstNumber % _secondNumber;
}//End GetMod


Console.WriteLine($"Suma: {GetSum(firstNumber,secondNumber)}");
Console.WriteLine($"Resta: {GetSubtraction(firstNumber,secondNumber)}");
Console.WriteLine($"Multiplicacion: {GetMultiplication(firstNumber,secondNumber)}");
Console.WriteLine($"Division: {GetDivision(firstNumber,secondNumber, false)}");
Console.WriteLine($"Division forzando decimal: {GetDivision(firstNumber,secondNumber, true)}");
Console.WriteLine($"Resto: {GetMod(firstNumber,secondNumber)}");
