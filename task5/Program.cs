// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

internal class Program
{
    private static void Main(string[] args)
    {
        int PrinTofValue (string message) {
            int value;
            Console.WriteLine(message);
            int.TryParse(Console.ReadLine(), out value);
            return value;
        }
        int secondNumber = PrinTofValue("Введите трёхзначное значение: ");
        if (secondNumber < 100 || secondNumber >= 1000) {
            Console.WriteLine("Вы ввели не трёхзначное число ! ! !");
        } 
        else 
        {
            Console.WriteLine(secondNumber / 10 % 10);
        }
        

        
    }
}