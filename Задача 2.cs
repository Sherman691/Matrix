using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

            int[,] GenerateMatrix(int lines, int columns, int lowRange, int topRange)
            {
                int[,] createdMatrix = new int[lines, columns];
                Random random = new Random();

                for (int i = 0; i < createdMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < createdMatrix.GetLength(1); j++)
                    {
                        createdMatrix[i, j] = random.Next(lowRange, topRange + 1);
                    }
                }
                return createdMatrix;
            }

            void Printmatrix(int[,] matrixForPrint)
            {
                for (int i = 0; i < matrixForPrint.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixForPrint.GetLength(1); j++)
                    {
                        Console.Write(matrixForPrint[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

            }

            
            //---------------------------------------------------------------------

            
            int[,] newMatrix = GenerateMatrix(5, 5, 0, 10);
            Printmatrix(newMatrix);
            
            int[,] flipMatrix = new int[newMatrix.GetLength(0), newMatrix.GetLength(1)];



            for (int i = 0; i < newMatrix.GetLength(1); i++)
            {
                flipMatrix[0, i] = newMatrix[newMatrix.GetLength(0)-1, i];
            }

            for (int i = 0; i < newMatrix.GetLength(1); i++)
            {
                flipMatrix[flipMatrix.GetLength(0) - 1, i] = newMatrix[0, i];
            }

            for(int i = 1; i < flipMatrix.GetLength(0)-1; i++)
            {
                for (int j = 0; j < flipMatrix.GetLength(1); j++)
                {
                    flipMatrix[i, j] = newMatrix[i, j];
                }
            }



            Console.WriteLine();
            Printmatrix(flipMatrix);

        }
    }
}
