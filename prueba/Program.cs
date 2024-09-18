string[] names = ["Alberto","Pepe","Juan"];

foreach(string name in names){
    if(name == "Pepe"){
        Console.WriteLine(name + " " + names[0]);
        names[0] = "Albertito";
        Console.WriteLine(name + " " + names[0]);
    }//End if
}//End for

string suffix;
for(int i = 1; i <= 100; i++){
    suffix = "";
    if (i%3 == 0){
        suffix += "Fizz";
    }//End if
    if (i%5 == 0){
        suffix += "Buzz";
    }//End if
    Console.WriteLine($"{i}{((suffix.Length>0)?" - " + suffix:suffix)}");
}//End for