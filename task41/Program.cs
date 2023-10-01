//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int WorkWithUser(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int number = Convert.ToInt32(value);
    return number;
}

int[] InputArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = WorkWithUser($"Введите {i + 1}-й элемент: ");
    }
    return array;
}

void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "," );
    }
    
}
int FoundPositiveNumbers (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}


int Length = WorkWithUser("Введите количество элементов: ");
int[] array;
array = InputArray(Length);
PrintArray (array);
Console.WriteLine($"Количество положительных чисел равно {FoundPositiveNumbers(array)}");
