using System.Runtime.CompilerServices;

string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};


string externalDomain = "hayworth.com";
string interanlDomain = "contoso.com";


string getUserName(string _firstName, string _lastName) {
    return _firstName[..2].ToLower() + _lastName.ToLower();
}//End getUserName

string getEmail(int _index, bool _isExternal = false){
    if (_isExternal) {
        string userName = getUserName(external[_index,0], external[_index,1]);
        return userName + "@" + externalDomain;
    }else{
        string userName = getUserName(corporate[_index,0], corporate[_index,1]);
        return userName + "@" + interanlDomain;
    }//End if
}//End getEmail

for (int i = 0; i < corporate.GetLength(0); i++) {
    Console.WriteLine(getEmail(i));
}//End for

for (int i = 0; i < external.GetLength(0); i++) {
    Console.WriteLine(getEmail(i,true));
}//End for