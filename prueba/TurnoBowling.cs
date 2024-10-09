using System;

namespace prueba;

public class TurnoBowling
{

 //int MyProperty { get; set; }

    
    int[] tiradas = new int[3];
    TurnoBowling? anterior;
    TurnoBowling? posterior;

    void setTirada(int numeroTirada, int valorTirada)
    {
        tiradas[numeroTirada] = valorTirada;
    }



}
