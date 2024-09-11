// See https://aka.ms/new-console-template for more 



Console.WriteLine("Hola, World!");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Azul???");
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("You wrote your first lines of code.\n");
Console.WriteLine("This is the first line.");
Console.Write("This is ");
Console.WriteLine("the second line.");
Console.WriteLine("123");
Console.WriteLine(123);
Console.WriteLine("true");
Console.WriteLine(true);
string firstName = "Bob";
Console.WriteLine(firstName);
var message = 1.6;
Console.WriteLine(message);

string nombre = "Bob";
int numeroMensajes = 3;
decimal grados = 34.4m;
Console.WriteLine("Hello, " + nombre + "! You have " + numeroMensajes + " messages in your inbox. The temperature is " + grados + " celsius.");
Console.WriteLine(string.Format("Hello, {0}! You have {1:d%} messages in your inbox. The temperature is {2} celsius.", nombre, numeroMensajes,grados));