using System;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
internal class Programm

{
    private static void Main(string[] args)
    {
        int[] array = new int[8];
        Random random = new Random();
        for (int i = 0; i < array.Length; i++) 
        {
            if (i < array.Length - 1)
            {
                array[i] = random.Next(0, 100);
                Console.Write(array[i] + ",");
            }
            else
            {
                Console.Write(array[i] + ".");
            }
           
        }
        



    }



}
