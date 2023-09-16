using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Programm
{

    private static void Main(string[] args)
    {
        int WorkWithUser(string message)

        {
            Console.Write(message);
            int number = int.Parse(Console.ReadLine());
            return number;
        }


        int[] GetArray(int length, int min, int max)
        {
            int[] result = new int[length];
            Random rand = new Random();
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = rand.Next(min, max + 1);
            }
            return result;

        }

        void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        void ChangeSigns (int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= -1;
                Console.Write(array[i]+ " ");
            }
        }
        int size = WorkWithUser("Введите количество элементов массива: ");
        int maxValue = WorkWithUser("Введите минимальную границу диапазона: ");
        int minValue = WorkWithUser("Введите максимальную границу диапазона: ");

        
        int[] NewArray = GetArray(size, maxValue, minValue);
        PrintArray(NewArray);
        Console.WriteLine();
        ChangeSigns(NewArray);

    }

}

