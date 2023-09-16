//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234]-> 2

using System.ComponentModel.DataAnnotations;

int WorkWithUser(string message)
{
    Console.Write(message);
    int numbers = int.Parse(Console.ReadLine());
    return numbers;
}

int[] GetArray(int length, int min, int max)
{
    int[] result = new int[length];
    Random rand = new Random();

    for (int i = 0; i < length; i++)
    {
        result[i] = rand.Next(min, max + 1);
    }

    return result;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int FoundEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
        else continue;
    }
    return count;
}

bool ValidateNumber(int max, int min)
{
    if (min < 100 && max > 999)
    {
        return false;
    }
    else
    {
        return true;
    }
}

int size = WorkWithUser("Введите количество элементов массива: ");
int maxValue = WorkWithUser("Введите максимальную границу диапазона трёхзначных чисел: ");
int minValue = WorkWithUser("Введите минимальную границу диапазона трёхзначных чисел : ");


if (ValidateNumber(maxValue, minValue) == false)
{
    Console.WriteLine("Ай ай ай, Вы ввели не трёхзначное число");
} else
{
    int[] array = GetArray(size, minValue, maxValue);
    PrintArray(array);
    Console.WriteLine($"Количество чётных чисел в массиве равно {FoundEvenNumbers(array)}");
}


