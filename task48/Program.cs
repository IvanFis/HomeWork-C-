//Задайте двумерный массив размера m на n,
//каждый элемент в массиве находится по формуле: Aₘₙ = m + n.
//Выведите полученный массив на экран.

int WorkWithUser(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] GetArray(int row, int column, int minValue, int maxValue)
{
    int[,] array = new int[row, column];
    Random rand = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int rows = WorkWithUser("Введите количество строк: ");
int columns = WorkWithUser("Введите количество столбцов: ");
int[,] matrix = new int[rows, columns];
