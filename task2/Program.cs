// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
static void FindMaxValue(int firstNumber, int secondNumber, int thirdNumber) {
    if (firstNumber > secondNumber) 
    {
        Console.WriteLine(firstNumber);
    } 
    else if (secondNumber > thirdNumber) 
    {
        Console.WriteLine(secondNumber);
    } 
    else 
    {
        Console.WriteLine(thirdNumber);
    }
}
FindMaxValue(100,2,340);