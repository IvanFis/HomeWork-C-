// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
internal class Programm
   
{
    private static void Main(string[] args)
    {
        
        {
            int numberA, numberB;
            Console.Write("Введите число, которое будет возводиться в степень: ");
            numberA = int.Parse(Console.ReadLine());
            Console.Write("Введите число, которое будет обозначать степень: ");
            numberB = int.Parse(Console.ReadLine());
            int result = numberA; 
            for (int i = 1; i < numberB; i++)
            {
                result *= numberA;
            }
            Console.WriteLine($"Число {numberA} в степени {numberB} равняется {result}");
        }
        
    }
    
    

}