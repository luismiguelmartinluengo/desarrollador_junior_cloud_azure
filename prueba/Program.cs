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
string firstName = "Luismi";

string nombre = "Bob";
int numeroMensajes = 3;
decimal grados = 34.4m;
Console.WriteLine("Hello, " + nombre + "! You have " + numeroMensajes + " messages in your inbox. The temperature is " + grados + " celsius.");
Console.WriteLine(string.Format("Hello, {0}! You have {1:d%} messages in your inbox. The temperature is {2} celsius.", nombre, numeroMensajes,grados));

Console.WriteLine("Hello \"World\"");

Console.OutputEncoding = System.Text.Encoding.UTF8;
// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");
string greeting = "Hola";
Console.WriteLine("\n-------------------Probando interpolacion----------------------------");
string message = $"{greeting} {firstName}!";
Console.WriteLine(message);

int version = 12;
string updateText = "Update to Windows";
message = $"{updateText} {version}";
Console.WriteLine(message);

Console.WriteLine("\n-------------------Probando interpolacion junto con string literal----------------------------");
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string englishMessage = "View English output:";
string russianPath = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
string englishPath = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"{englishMessage}\n\t{englishPath}");
Console.WriteLine($"{russianMessage}\n\t{russianPath}");