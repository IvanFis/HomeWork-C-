// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
        int firstNumber;
        int secondNumber;
        Console.Write("Введите первое число: ");
        int.TryParse(Console.ReadLine(), out firstNumber);
        Console.Write("Введите второе число: ");
        int.TryParse(Console.ReadLine(), out secondNumber);

        if (firstNumber > secondNumber)
        {
            Console.WriteLine("Max: " + firstNumber);
        }
        else
        {
            Console.WriteLine("Max: " + secondNumber);
        }
    }
}