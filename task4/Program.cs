// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


internal class Program
{
    private static void Main(string[] args)
    {
        int number = 0;
        Console.Write("Введите число: ");
        int.TryParse(Console.ReadLine(),out number);
        for (int i = 2; i <= number; i++) 
        {
            if (i % 2 == 0){
            Console.WriteLine(i);
            }

        }

    }
}