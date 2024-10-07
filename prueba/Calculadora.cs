namespace prueba;

public class Calculadora(){
    //Calculadora basica

    public int? sum(int? _a, int? _b){
        return _a + _b;
    }//End Sum

    public int? subtraction(int? _a, int? _b){
        return sum(_a, -_b);
    }//End Resta

    public int? multiplication(int? _a, int? _b){
        return _a * _b;
    }//End multiplication

    public double? division(double _a, double _b){
        if (_b.Equals(0)){
            return null;
        }else{
            return _a / _b;
        }//End if
    }//End division


}//End Calculadora