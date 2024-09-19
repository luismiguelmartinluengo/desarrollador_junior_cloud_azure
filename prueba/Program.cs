int?[] pallets = { 8, 15, 35, 3 };
writeArray(pallets);

Array.Sort(pallets);
writeArray(pallets);

Array.Clear(pallets, 1,2);
writeArray(pallets);

Array.Resize(ref pallets, 6);
writeArray(pallets);

void writeArray(Array _array){
    Console.WriteLine($"Escritura de array con longitud {_array.Length}");
    foreach (var item in _array){
        Console.WriteLine($"-- {item}");
    }//End foreach
}//Enf writeArray