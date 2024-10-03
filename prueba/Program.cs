/*  
This code instantiates a value and then calls the ChangeValue method
to update the value. The code then prints the updated value to the console.
*/
internal class Program
{
    private static void Main(string[] args){
        int x = 5;

        ChangeValue(x ,out x);

        Console.WriteLine(x);

        void ChangeValue(int entrada, out int salida){
            salida = entrada + 10;
        }//End ChangeValue
    }
}