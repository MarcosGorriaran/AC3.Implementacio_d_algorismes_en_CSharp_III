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
using System;
namespace AlgoritmosIII
{
    class Execute
    {
        public static void Main()
        {
            const char WordSpliter = ' ';

            int[] a = { 10, 20, 30, 20, 10, 50, 60, 40, 80, 50, 40 };
            int[] withoutCopys = new int[0];
            bool alreadyExists = false;

            for (int i = 0; i < a.Length; i++)
            {
                int j = 0;
                while (j < withoutCopys.Length && !alreadyExists)
                {
                    if (withoutCopys[j] == a[i])
                    {
                        alreadyExists = true;
                    }
                    j++;
                }
                if (!alreadyExists)
                {
                    int[] temp = withoutCopys;
                    withoutCopys = new int[withoutCopys.Length + 1];
                    for (j = 0; j < temp.Length; j++)
                    {
                        withoutCopys[j] = temp[j];
                    }
                    withoutCopys[withoutCopys.Length - 1] = a[i];
                }
                alreadyExists = false;
            }

            for (int i = 0; i < withoutCopys.Length; i++)
            {
                Console.Write(withoutCopys[i] + WordSpliter);
            }
        }
    }
}