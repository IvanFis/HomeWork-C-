int WorkWithUser(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

string CheckName(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()!;
    return value;
}

bool CheckingTheVerifier(string message)
{

    if (message == "Эльвира")
    {
        return true;
    }
    return true;
}

int FindLengthOfArray(int valueM, int valueN)
{
    int length = 1;
    if (valueM > valueN)
    {
        length = valueM - valueN;
    }
    else
    {
        length = valueN - valueM;
    }
    return length + 1;
}

int[] GetArray(int valueN, int valueM, int number)
{
    int[] array = new int[number];
    
    if (valueM > valueN)
    {
        for (int i = 0; i < number; i++)
        {
            array[i] = valueN;
            valueN += 1;
        }
    }
    else
    {
        for (int i = 0; i < number; i++)
        {
            array[i] = valueM;
            valueM += 1;
        }
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int FindSum(int[] arr)
{
    int sum = 0;
    {
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
    }
    return sum;
}

int value1 = WorkWithUser("Введите первое значение: ");
int value2 = WorkWithUser("Введите второе значение: ");
string name = CheckName("Введите Ваше имя на русской расскладке с Заглавной буквы: ");

int[] array = GetArray(value1, value2, FindLengthOfArray(value1, value2));
PrintArray(array);
Console.WriteLine();
Console.WriteLine(FindSum(array));
Console.WriteLine($"Как ни крути, но это {CheckingTheVerifier(name)}, что Вы самая чуткая, понимающая и отзывчивая преподавательница, большое вам спасибо за этот курс.");
