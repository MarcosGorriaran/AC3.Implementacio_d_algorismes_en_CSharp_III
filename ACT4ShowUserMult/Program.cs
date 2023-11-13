/*
 * Author: Gorriaran Caamaño Marcos Facundo
 * M03. Programació UF1
 * v1. 13/11/2001
 * Exercici 2. 
 * Implementa un programa que demani a l’usuari quants valors vol
 * introduir i el programa generi una llista, a partir de valors
 * introduïts per teclat, retornant la suma de tots els elements
 * d’aquesta.
 */

namespace AlgoritmosIII
{
    class Execute
    {
        public static void Main()
        {
            const string AskLength = "Cuantos valores quieres ver en la lista de multiplos: ";
            const string AskMult = "Dame el exponente: ";

            int[] userArray;
            int mult;

            Console.WriteLine(AskLength);
            userArray = new int[Convert.ToInt32(Console.ReadLine())];

            Console.WriteLine();
        }
    }
}