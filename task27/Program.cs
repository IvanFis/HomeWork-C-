using System;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Programm
{


    private static void Main(string[] args)
    {
        int WorkWithUser(string message)
        {
            System.Console.Write(message);
            string value = Console.ReadLine();
            int result = int.Parse(value);
            return result;
        }

        int FindSumOfNumbers(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        int number = WorkWithUser("Введите значение: ");
        Console.WriteLine($"Сумма равна {FindSumOfNumbers(number)}");
    }
}

