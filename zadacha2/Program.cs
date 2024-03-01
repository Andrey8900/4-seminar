//Задайте массив заполненный случайными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
using System;
class Program
{
    static void Main()
    {
        Random rnd = new Random();

        int[] numbers = new int[10];

        int evenCount = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next(100, 1000);
            Console.Write(numbers[i] + " ");


            if (numbers[i] % 2 == 0)
            {
                evenCount++;
            }
            Console.WriteLine($"\nКоличество четных чисел в массиве: {evenCount}");

        }

    }
}