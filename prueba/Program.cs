Console.WriteLine(DateTime.Now.ToLongTimeString());
Console.WriteLine(DateTime.UtcNow.ToLongTimeString());
Console.WriteLine(DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.ffff"));

DateTime hoy = DateTime.UtcNow;
Console.WriteLine(hoy.ToUniversalTime());
Console.WriteLine(hoy.AddMonths(1));
DateTime fecha = new DateTime(2023,1,30);
Console.WriteLine(fecha.AddMonths(1).Ticks);
