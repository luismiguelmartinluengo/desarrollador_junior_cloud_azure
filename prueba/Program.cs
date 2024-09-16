Random random = new();

int[] matriz = new int[6];
for (int i = 0; i < 6; i++){
    matriz[i] = random.Next(100);
}//End for
foreach(int i in matriz){
    Console.WriteLine(i);
}//End for