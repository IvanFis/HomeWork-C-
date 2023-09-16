using System;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Programm
{



    private static void Main(string[] args)
    {
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
        int size = 12;
        int minValue = -9;
        int maxValue = 9;

        int[] array = GetArray(size, minValue, maxValue);
        PrintArray(array);


        int[] GetSums(int[] inArray)
        {
            int[] res = new int[2];

            foreach (int el in inArray)
            {
                if (el > 0) res[0] += el;
                else res[1] += el;
            }
            return res;
        }
        int[] sums = GetSums(array);
        Console.WriteLine($"Сумма положительных чисел равна: {sums[0]}, сумма отрицательных чисел равна: {sums[1]}");
    }
    }
