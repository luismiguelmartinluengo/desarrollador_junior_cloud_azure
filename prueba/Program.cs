
namespace prueba;
/*  
This code instantiates a value and then calls the ChangeValue method
to update the value. The code then prints the updated value to the console.
*/
class Program
{
    private static void Main(string[] args){

        Katas katas = new();

        for (int i = 1; i < 16; i++){
            Console.WriteLine(katas.JuegoMultiplos(i+100));
        }//End for

    }//End Main
}//End Promgram