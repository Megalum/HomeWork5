using System;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Input(string str)
            {
                Console.Write(str);
                return Convert.ToInt32(Console.ReadLine());
            }

            void ArrayWrite(int[] array, int dimension)
            {
                for (int index = 0; index < dimension - 1; index++)
                {
                    Console.Write(array[index] + ", ");
                }
                Console.WriteLine(array[dimension - 1]);
            }

            int[] ArrayAllRandom(int dimension)
            {
                int[] array = new int[dimension];
                for (int index = 0; index < dimension; index++)
                {
                    array[index] = new Random().Next(-1000, 1000);
                }
                return array;
            }

            //Задание 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
            int[] ArrayThreeDigitRandom(int dimension)
            {
                int[] array = new int[dimension];
                for (int index = 0; index < dimension; index++)
                {
                    array[index] = new Random().Next(99, 1000);
                }
                return array;
            }

            int CountEvenNumbers(int[] array, int dimension)
            {
                int count = 0;
                for (int index = 0; index < dimension; index++)
                {
                    if (array[index] % 2 == 0)
                    {
                        count++;
                    }
                }
                return count;
            }

            Console.WriteLine("Задание 1:");
            int dimension = Input("Введите размерность массива: ");
            int[] array = new int[dimension];
            array = ArrayThreeDigitRandom(dimension);
            ArrayWrite(array, dimension);
            int count = CountEvenNumbers(array, dimension);
            Console.WriteLine("Колличество четных чисел в массиве = " + count);
            Console.WriteLine();

            //Задание 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
            int SummUnevenIndex(int[] array, int dimension)
            {
                int Summ = 0;
                for (int index = 0; index < dimension; index++)
                {
                    if (index % 2 == 1)
                    {
                        Summ += array[index];
                    }
                }
                return Summ;
            }

            Console.WriteLine("Задание 2:");
            dimension = Input("Введите размерность массива: ");
            array = ArrayAllRandom(dimension);
            ArrayWrite(array, dimension);
            int summ = SummUnevenIndex(array, dimension);
            Console.WriteLine("Сумма чисел стоящих на нечетных позициях = " + summ);
            Console.WriteLine();

            //Задание 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
            int Difference(int[] array, int dimension)
            {
                int min = array[0], max = array[0];
                for (int index = 0; index < dimension; index++)
                {
                    if (min > array[index])
                    {
                        min = array[index];
                    }
                    if (max < array[index])
                    {
                        max = array[index];
                    }
                }
                return max - min;
            }

            Console.WriteLine("Задание 3:");
            dimension = Input("Введите размерность массива: ");
            array = ArrayAllRandom(dimension);
            ArrayWrite(array, dimension);
            double difference = Difference(array, dimension);
            Console.WriteLine("Разница между максимальным и минимальным элементами массива = " + difference);


            Console.ReadKey();
        }
    }
}
