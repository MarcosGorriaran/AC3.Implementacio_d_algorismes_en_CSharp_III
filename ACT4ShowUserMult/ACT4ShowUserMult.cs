/*
 * Author: Gorriaran Caamaño Marcos Facundo
 * M03. Programació UF1
 * v1. 13/11/2001
 * Exercici 4. 
 * Implementa un programa que generi un array, indicant la seva mida per
 * teclat. L’usuari haurà d’indicar un número per teclat, de manera que els
 * valors de cada posició seran nombres múltiples consecutius del valor
 * introduït per teclat. Per exemple, si es defineix un array de grandària
 * 5 i s’indica un 3 com a valor, l’array contindrà els valors 3, 6, 9, 12,
 * 15.
 */
using System;
namespace AlgoritmosIII
{
    class Execute
    {
        public static void Main()
        {
            const string AskLength = "Cuantos valores quieres ver en la lista de multiplos: ";
            const string AskMult = "Dame el exponente: ";
            const string ShowCreatedList = "La lista creada a partir de los datos es el siguiente: ";
            const string  WordSpliter = " ";

            int[] userArray;
            int mult;

            Console.Write(AskLength);
            userArray = new int[Convert.ToInt32(Console.ReadLine())];

            Console.Write(AskMult);
            mult = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ShowCreatedList);
            for(int i = 0; i < userArray.Length ; i++)
            {
                userArray[i] = (i + 1) * mult;
                Console.Write(userArray[i]+WordSpliter);
            }

            
        }
    }
}