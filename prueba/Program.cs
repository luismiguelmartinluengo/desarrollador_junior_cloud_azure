int value = 0;
value = value + 5; Console.WriteLine(value);
value += 5; Console.WriteLine(value);
value++; Console.WriteLine(value);
value -= 3; Console.WriteLine(value);
--value; Console.WriteLine(value);

int ConvertFahrenheitToCelsius(int _fahrenheit){
    return (int) ((_fahrenheit - 32) * (5/9.0));
}//End ConvertFarenheitToCelsius

int fahrenheit = 94;
Console.WriteLine($"{fahrenheit} grados Fahrenheit son {ConvertFahrenheitToCelsius(fahrenheit)} grados Celsius");