//Напишите программу, которая перевернёт одномерный массив
//(первый элемент станет последним, второй – предпоследним и т.д.)

using System;
class Program
{
    static void Main()
    {
        int[] f = { 5, 4, 13, 9, 22 };
        int invertedArray;
        Console.Write("Исходный массив: ");
        foreach (int number in f)
        {
            Console.Write(number + " ");
        }

        for (int i = 0; i < f.Length / 2; i++)
        {
            invertedArray = f[i];
            f[i] = f[f.Length - i - 1];
            f[f.Length - i - 1] = invertedArray;
        }
        Console.Write("\nПеревернутый массив: ");
        foreach (int number in f)
        {
            Console.Write(number + " ");
        }

    }
}

