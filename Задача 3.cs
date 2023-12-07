using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

            int ReadConsol(string text)
            {
                Console.Write(text);
                return Convert.ToInt32(Console.ReadLine());
            }

            //-----------------------------------------------

            int strouks = ReadConsol("Задайте колличество строк: ");
            int colons = ReadConsol("Задайте колличество столбцов: ");

            int[,] matrix = GenerateMatrix(strouks, colons, 0, 10);
            Printmatrix(matrix);

            int[] sumMin = new int[matrix.GetLength(0)];
            

            for(int i = 0; i < sumMin.Length; i++)
            {
                sumMin[i] = 0;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sumMin[i] += matrix[i, j];
                }
            }

            

            int indexMinStrouk = 0;
            int sumStrouk = sumMin[0];
            for (int i = 0; i < sumMin.Length; i++)
            {
                if (sumMin[i] < sumStrouk)
                {
                    sumStrouk = sumMin[i];
                    indexMinStrouk = i;
                }
            }


            Console.WriteLine($"Строка с наименьшей суммой элементов {indexMinStrouk+1} ({sumStrouk})");



        }
    }
}
