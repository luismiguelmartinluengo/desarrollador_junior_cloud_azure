Random random = new Random();

//int discountPercentage = 0;

while (true){
        int daysUntilExpiration = random.Next(12);
        if (daysUntilExpiration < 11){
            if (daysUntilExpiration > 4){
                Console.WriteLine("Your subscription will expire soon. Renew now!!");
                Console.WriteLine(daysUntilExpiration);

            }else if (daysUntilExpiration >1){
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\tRenew now and save 10%!");
            }else if (daysUntilExpiration >0){
                Console.WriteLine($"Your subscription expires within a day!\tRenew now and save 20%!");
                Console.WriteLine("Your subscription has expired.");
            }//End if
        };//End 

        // Esperar a que el usuario pulse una tecla
        Console.WriteLine("Presiona cualquier tecla para volver a ejecutar o 'Esc' para salir.");
        var key = Console.ReadKey(true).Key;

        // Salir del bucle si se pulsa la tecla 'Esc'
        if (key == ConsoleKey.Escape){
            break;
        }//End f
}//End if