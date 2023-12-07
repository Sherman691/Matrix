using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
            //и возвращает значение этого элемента или же указание, что такого элемента нет.

            int[,] GenerateMatrix(int lines, int columns, int lowRange, int topRange)
            {
                int[,] createdMatrix = new int[lines, columns];
                Random random = new Random();

                for(int i =0; i<createdMatrix.GetLength(0); i++)
                {
                    for(int j = 0; j<createdMatrix.GetLength(1); j++)
                    {
                        createdMatrix[i, j] = random.Next(lowRange, topRange + 1);
                    }
                }
                return createdMatrix;
            }
                
            void Printmatrix(int[,] matrixForPrint)
            {
                for(int i=0; i<matrixForPrint.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixForPrint.GetLength(1); j++)
                    {
                        Console.Write(matrixForPrint[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                
            }

            int ReadConsol(string text)
            {
                Console.Write(text);
                return Convert.ToInt32(Console.ReadLine());
            }
            //---------------------------------------------------------------------


            int[,] newMatrix = GenerateMatrix(5, 5, 0, 10);
            Printmatrix(newMatrix);

            int YCoordinate = ReadConsol("Введите номер строки: ");
            int XCoordinate = ReadConsol("Введите номер столбца: ");

            if (YCoordinate > newMatrix.GetLength(0) | XCoordinate > newMatrix.GetLength(1) | YCoordinate <= 0 | XCoordinate <= 0) Console.WriteLine($"Элемента с координатами {YCoordinate} и " +
                $"{XCoordinate} нет");
            else
            {
                Console.WriteLine(newMatrix[YCoordinate-1, XCoordinate-1]);
            }




        }
    }
}
