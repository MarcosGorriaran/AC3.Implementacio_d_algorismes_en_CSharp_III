/*
 * Author: Gorriaran Caamaño Marcos Facundo
 * M03. Programació UF1
 * v1. 13/11/2001
 * Exercici 5. 
 *  Implementa un programa que generi una matriu de 4x4 i
 *  mostri la diagonal principal (pots inicialitzar-la amb els
 *  valors enters que consideris).
 */
using System;
namespace AlgoritmosIII
{
    class Execute
    {
        public static void Main()
        {

            const int Row = 4;
            const int Col = 4;
            const string WordSpliter="  ";

            string[,] list = { { "00", "01", "02", "03" }, { "10", "11", "12", "13" }, { "20", "21", "22", "23" }, { "30", "31", "32", "33" } };

            for (int i = 0; i < list.GetLength(0); i++)
            {
                for(int j = 0; j < list.GetLength(1); j++)
                {
                    if(i == j)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    Console.Write(list[i, j]);
                    Console.ResetColor();
                    Console.Write(WordSpliter);
                }
                Console.WriteLine();
            }
        }
    }
}