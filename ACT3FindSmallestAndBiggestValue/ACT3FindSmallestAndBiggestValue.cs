/*
 * Author: Gorriaran Caamaño Marcos Facundo
 * M03. Programació UF1
 * v1. 13/11/2001
 * Exercici 3. 
 *  Implementa un programa que, donada la següent llista, retorni l’element
 *  més gran i el més petit.
 */
using System;
namespace AlgoritmosIII
{
    class Execute
    {
        public static void Main()
        {
            const string ShowBiggest = "This is the biggest value: ";
            const string ShowSmallest = "This is the smallest value: ";

            int[] lista = new int[] { 5, 10, 15, 2, 25, 30, 35, 40 };
            int smallest = lista[0];
            int biggest = lista[0];

            for(int i = 1; i < lista.Length; i++)
            {
                if (lista[i]<smallest)
                {
                    smallest = lista[i];
                }
                if (lista[i]>biggest)
                {
                    biggest = lista[i];
                }
            }

            Console.WriteLine(ShowSmallest+smallest);
            Console.WriteLine(ShowBiggest+biggest);
        }
    }
}