using System.ComponentModel.Design;

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

bool ValidOfMultiplication(int[,] matrix1, int[,] matrix2)
{

    if (matrix1.GetLength(0) == matrix2.GetLength(1) || matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        return true;
    }
    else
    {
        return false;
    }
}

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] array = new int[2, 2];
    {
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                for (int k = 0; k < matrix2.GetLength(0); k++)
                {
                    array[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
    }
    return array;
}

int[,] array1 = GetArray(2, 2, 7, 1);
int[,] array2 = GetArray(2, 2, 7, 1);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();

if (ValidOfMultiplication(array1,array2))
{
    PrintArray(MatrixMultiplication(array1,array2));  
}  
else
{
    Console.WriteLine("Умножение матриц невозможно!");
}