using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Part_2
{
    class Matrix
    {
        int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            matrix.displayMatrix();
            matrix.transposeMatrix();
            Console.ReadLine();
        }

        public void displayMatrix()
        {
            Console.WriteLine("Original matrix:");

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < numbers.GetLength(0); j++)
                {
                    Console.Write(numbers[i, j]);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public void transposeMatrix()
        {
            Console.WriteLine("Transposed matrix:");
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < numbers.GetLength(0); j++)
                {
                    Console.Write(numbers[j, i]);
                }
            }
        }
    }
}
