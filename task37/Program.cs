//Задача 37: Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний 
//и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5]-> 5 8 3
//[6 7 3 6]-> 12 10

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

void findMultuplication( int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        result = arr[i] * arr[arr.Length - i - 1];
        Console.Write($"Произведение равно: {result} ");
    }
}

int size = WorkWithUser("Введите количество элементов массива: ");
int maxValue = WorkWithUser("Введите максимальную границу диапазона: ");
int minValue = WorkWithUser("Введите минимальную границу диапазона: ");

int[] array = GetArray(size, minValue, maxValue);
PrintArray(array);

findMultuplication(array);