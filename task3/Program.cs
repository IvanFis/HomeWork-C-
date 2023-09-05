//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
using System.ComponentModel.DataAnnotations;
internal class Program
{
    private static void Main(string[] args)
    {
        int number;
        Console.WriteLine("Введите число: ");
        Int.TryParse(Console.ReadLine(), out number);
        if (number % 2 == 0) {
            Console.WriteLine("Да");
        } 
        else
        {
            Console.WriteLine("Нет");
        } 
}
}