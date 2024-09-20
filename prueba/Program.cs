string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
Console.WriteLine($"Our new product, Glorious Future offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");
Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage = string.Format("{0}{1}{2}\n{3}{4}{5}",currentProduct.PadRight(20),
                                                        currentReturn.ToString("P").PadRight(8),
                                                        currentProfit.ToString("C").PadLeft(15),
                                                        newProduct.PadRight(20),
                                                        newReturn.ToString("P").PadRight(8),
                                                        newProfit.ToString("C").PadLeft(15));

Console.WriteLine(comparisonMessage);

