//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
internal class Program
{
    private static void Main(string[] args)
    {
        int number;
        Console.WriteLine("Введите число: ");
        int.TryParse(Console.ReadLine(), out number);
        if (number % 2 == 0)
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
    }
}