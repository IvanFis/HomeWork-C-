
//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4

//В итоге получается вот такой массив:

//7 4 2 1
//9 5 3 2
//8 4 4 2

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

int[,] SortArray(int[,] array) 
{ 


    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0;j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(1)-1; l++)
            {
                if (array[i, l] < array[i, l + 1])
                {
                    int temp = array[i, l + 1];
                    array[i, l + 1] = array[i, l];
                    array[i, l] = temp;
                }
            }           
        }
    }
    return array;
}

int[,] array = GetArray(3, 4, 10, 1);
PrintArray(array);
Console.WriteLine();
SortArray(array);
PrintArray(array);