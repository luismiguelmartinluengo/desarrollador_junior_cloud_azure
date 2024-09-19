string[] values = { "12.3", "45", "ABC", "11", "DEF" };
string message = "";
float total = 0;

foreach(string stringValue in values){
    if (float.TryParse(stringValue, out float textConverted)){
        total += textConverted;
    }else{
        message += stringValue;
    }//End if
}//End foreach
Console.WriteLine($"Message: {message}\nTotal: {total}");