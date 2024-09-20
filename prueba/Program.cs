const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

int quantityStart = input.IndexOf("<span>") + 6;
int quantityEnd = input.IndexOf("</span>");
string quantity = input.Substring(quantityStart,quantityEnd-quantityStart);
string output = input.Replace("<div>","").Replace("</div>","").Replace("&trade","&reg");

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");

