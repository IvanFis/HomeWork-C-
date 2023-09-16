using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Programm
{
    //Задайте массив.Напишите программу, которая определяет, присутствует ли заданное число в массиве.

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


        int size = WorkWithUser("Введите количество элементов массива: ");
        int maxValue = WorkWithUser("Введите максимальную границу диапазона: ");
        int minValue = WorkWithUser("Введите минимальнуюграницу диапазона: ");
        int number = WorkWithUser("Введите число: ");

        
        int[] array = GetArray(size, minValue, maxValue);
        bool findNumber(int value)
        {
            bool found = false;
            for (int i = 0; i < size; i++)
            {
                if (array[i] == value)
                {
                    found = true;
                    break;
                }
                else
                {
                    found = false;
                }
            }
            return found;

        }
        PrintArray(array);
        Console.WriteLine(findNumber(number));

    }

}

