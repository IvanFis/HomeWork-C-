
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
internal class Program
{
    private static void Main(string[] args)
    {
        int PrintOfValue( string message)
        {
            Console.WriteLine(message);
            string value = Console.ReadLine();
            int number = Convert.ToInt32(value);
            return number;
        }
        int thirdNumber = PrintOfValue("Введите число: ");
        int FindThirdValue ( int thirdnumber) {
            while (thirdNumber > 1000) {
                thirdNumber /= 10;
            } 
            return thirdNumber % 10; 
        }
        
        bool checkValue (int number) 
        {
            if (number < 100) {
                Console.WriteLine("Третьей цифры нет");
                return false;
            } 
            return true;    
        } 
        if (checkValue(thirdNumber)) {
            Console.WriteLine(FindThirdValue(thirdNumber));
        }
    } 
   
}
