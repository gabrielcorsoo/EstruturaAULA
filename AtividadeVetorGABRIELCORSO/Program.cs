using System;

class Program
{
    static void Main()
    {
        int[] pares = new int[50]; 
        int[] impares = new int[50];

        int numPar = 0;  
        int numImpar = 1; 

        for (int i = 0; i < 50; i++)
        {
            pares[i] = numPar;
            numPar += 2; 
        }
        for (int i = 0; i < 50; i++)
        {
            impares[i] = numImpar;
            numImpar += 2; 
        }

        Console.WriteLine("Números Pares:");
        for (int i = 0; i < 50; i++)
        {
            Console.Write(pares[i] + " ");
        }

        Console.WriteLine("\n");

        Console.WriteLine("Números Ímpares:");
        for (int i = 0; i < 50; i++)
        {
            Console.Write(impares[i] + " ");
        }
    }
}
