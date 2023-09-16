//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12]-> 19
//[-4, -6, 89, 6]-> 0

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


int FindSum (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
        else continue;
    }
    return sum;
}

int size = WorkWithUser("Введите количество элементов массива: ");
int maxValue = WorkWithUser("Введите максимальную границу диапазона  чисел: ");
int minValue = WorkWithUser("Введите минимальную границу диапазона  чисел : ");

int[] array = GetArray(size, minValue, maxValue);
PrintArray(array);
Console.WriteLine($"Сумма чисел с нечётными индексами равна {FindSum(array)}");