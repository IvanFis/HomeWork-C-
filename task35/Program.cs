//Задача 35: Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в 
//отрезке [10, 99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2]-> 1
//[1, 2, 3, 6, 2]-> 0
//[10, 11, 12, 13, 14]-> 5



int WorkWithUser(string message)

{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int[] GetArray(int length, int min, int max)
{
    int[] result = new int[length];
    Random rand = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rand.Next(min, max + 1);
    }
    return result;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int findQuantity(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99) 
        {
            result++;
        }
    }
    return result;
}


int size = WorkWithUser("Введите количество элементов массива: ");
int maxValue = WorkWithUser("Введите максимальную границу диапазона: ");
int minValue = WorkWithUser("Введите минимальную границу диапазона: ");

int[] array = GetArray(size, minValue, maxValue);
PrintArray(array);
Console.WriteLine($"Количество равняется : {findQuantity(array)}") ;
