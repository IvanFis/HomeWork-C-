// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        int PromptOfValue(string message)
        {
            Console.Write(message);
            string value = Console.ReadLine();
            int number = Convert.ToInt32(value);
            return number;
        }

        bool ValidNumberOfDay(int number)
        {
            if (number >= 1 && number <= 7)
            {
                return true;
            }
            Console.WriteLine("Вы ввели не номер дня недели");
            return false;
        }
        bool isWeekend(int number)
        {
            if (number >= 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        int DayOfWeek = PromptOfValue("Введите номер дня недели:");

        if (ValidNumberOfDay(DayOfWeek))
        {
            if (isWeekend(DayOfWeek))
            {
                Console.WriteLine("Выходной");
            }
            else
            {
                Console.WriteLine("Отдых совсем скоро, держимся");
            }
        }
    }
}


        
    
