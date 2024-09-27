
string ip = "143.111.2.111";

bool ValidateLength(string _ip) {
    string[] address = _ip.Split(".");
    return address.Length == 4;
}//End ValidateLenth

bool ValidateZeroes(string _ip) {

    string[] getAddressArray(string _ip){
        return _ip.Split(".");
    }//End getAddressArray

    string[] address = getAddressArray(_ip);

    foreach(string number in address){
        //if (number.Length > 1 && number.StartsWith("0")){
        if (number.Length > 1 && number[0] == '0'){
          return false;
        }//End if    
    }//End foreach
    return true;
}//End ValidateZeroes

bool ValidateRange(string _ip) {
    string[] address = _ip.Split(".");
    int numberValue;
    foreach(string numberString in address){
        numberValue = int.Parse(numberString);
        if (numberValue < 0 || numberValue > 255){
            return false;
        }//End if
    }//End foreach
    return true;
}//End ValidateRAnge



if (ValidateLength(ip) && ValidateZeroes(ip) && ValidateRange(ip)){
    Console.WriteLine($"ip is a valid IPv4 address");
}else{
    Console.WriteLine($"ip is an invalid IPv4 address");
}//End if
