using System.Globalization;

CultureInfo.CurrentCulture = new CultureInfo("en-US");


decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units");

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P}");

decimal price2 = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = string.Format("You saved {0:C2} off the regular {1:C2} price. ", price2 - salePrice, price);
Console.WriteLine(yourDiscount);

string input = "Pad this";
 Console.WriteLine(input.PadLeft(12, '-'));
 Console.WriteLine(input.PadLeft(12, '-'));
 Console.WriteLine(input.PadRight(12, '-'));