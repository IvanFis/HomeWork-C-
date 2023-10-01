static int[,] GetArray(int rows, int columns, int max, int min)
{
    Random rand = new Random();
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(min, max + 1);
        }
    }
    return array;

}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write("\t");
        }
        Console.WriteLine();
    }
}


int[] FindSumOfStrings(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumOfString = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumOfString += matrix[i, j];
            array[i] = sumOfString;
        }

    }
    return array;
}

int FindMinimalSum(int[] array)
{
    int minSum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minSum)
        {
            minSum = array[i];
        }
    }
    return minSum;
}


void PrintResult(int number, int[]array)
{
    int numberOfString = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (number == array[i])
        {
            numberOfString = i + 1;break;
        }
    }
    Console.WriteLine($"  Строка с наименьшей суммой {number} под номером {numberOfString}");
}

void PrintSums(int[] array)
{
    for (int i = 0;i < array.Length; i++) 
    {
        Console.WriteLine(array[i]);
        
    }
}

int[,] arr = GetArray(4, 4, 10, 1);
PrintArray(arr);
Console.WriteLine();
PrintSums(FindSumOfStrings(arr));
Console.WriteLine();
PrintResult((FindMinimalSum(FindSumOfStrings(arr))), (FindSumOfStrings(arr)));