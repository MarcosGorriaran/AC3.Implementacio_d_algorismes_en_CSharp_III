/*
 * Author: Gorriaran Caamaño Marcos Facundo
 * M03. Programació UF1
 * v1. 12/11/2001
 * Exercici 1. 
 * Implementa un programa que demani a l’usuari quants valors vol introduir 
 * i el programa generi una llista, a partir de valors introduïts per teclat,
 * retornant la suma de tots els elements d’aquesta.
 */

namespace AlgoritmosIII
{
    class Execute
    {
        public static void Main()
        {
            const string AskLength = "Cuantos valores introduciras: ";
            const string AskValue = "Proporcioname el valor {0}: ";
            const string ShowList = "Lista de valores proporcionados: ";
            const string SumResult = "Resultado de suma de valores";
            const char WordSpliter = ' ';

            int[] userValues;
            int sum = 0;

            Console.Write(AskLength);
            userValues = new int[Convert.ToInt32(Console.ReadLine())];

            for (int i = 0; i < userValues.Length; i++)
            {
                Console.Write(AskValue, i+1);
                userValues[i] = Convert.ToInt32(Console.ReadLine());
                sum += userValues[i];
            }

            Console.Write(ShowList);
            for (int i = 0; i < userValues.Length; i++)
            {
                Console.Write(userValues[i]+WordSpliter);
            }
            Console.WriteLine();
            Console.WriteLine(SumResult + sum);
        }
    }
}