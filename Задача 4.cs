using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задайте двумерный массив из целых чисел.
            //Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
            //Под удалением понимается создание нового двумерного массива без строки и столбца

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
            //---------------------------


            int[,] matrix = GenerateMatrix(5, 5, 0, 10);
            Printmatrix(matrix);

            int[,] cropMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

            int indexLowNumber = matrix[0, 0];
            int YCoordinate = 0;
            int XCoordinate = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < indexLowNumber)
                    {
                        YCoordinate = i;
                        XCoordinate = j;
                        indexLowNumber = matrix[i, j];
                    }
                }
            }

            Console.WriteLine(YCoordinate + 1);
            Console.WriteLine(XCoordinate + 1);
            Console.WriteLine(indexLowNumber);

            for (int i = 0, j = 0; i < matrix.GetLength(0); i++)
            {
                if (i == YCoordinate)
                    continue;
                for (int k = 0, u = 0; k < matrix.GetLength(1); k++)
                {
                    if (k == XCoordinate)
                        continue;
                    cropMatrix[j, u] = matrix[i, k];
                    u++;
                }
                j++;                                
            }

            Console.WriteLine();
            Printmatrix(cropMatrix);
        }
    }
}
