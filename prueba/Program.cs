Random random = new Random();

bool continua = true;

while (continua){
        int daysUntilExpiration = random.Next(12);
        if (daysUntilExpiration < 11){
            if (daysUntilExpiration > 4){
                Console.WriteLine("Your subscription will expire soon. Renew now!!");
            }else if (daysUntilExpiration >1){
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save 10%!");
            }else if (daysUntilExpiration >0){
                Console.WriteLine($"Your subscription expires within a day!\nRenew now and save 20%!");
            }else{
                Console.WriteLine("Your subscription has expired.");
            }//End if
        };//End if

        // Esperar a que el usuario pulse una tecla
        Console.WriteLine("Presiona cualquier tecla para volver a ejecutar o 'Esc' para salir.");
        var key = Console.ReadKey(true).Key;

        // Salir del bucle si se pulsa la tecla 'Esc'
        if (key == ConsoleKey.Escape){
            continua = false;
        }//End f
}//End if