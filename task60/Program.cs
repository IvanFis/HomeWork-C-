//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0, 1, 0)
//34(1, 0, 0) 41(1, 1, 0)
//27(0, 0, 1) 90(0, 1, 1)
//26(1, 0, 1) 55(1, 1, 1)

static int[, ,] GetArray(int x, int y, int z, int max, int min)
{
    Random rand = new Random();
    int[,,] array = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for(int k = 0; k < z; k++)
            array[i, j, k] = rand.Next(min, max + 1);
        }
    }
    return array;

}

void PrintArray(int[,,] matrix)
{
    for (int i = 0;i < matrix.GetLength(0);i++)
    {1ё
        for (int j = 0; j < matrix.GetLength(1);j++)
        {
            for (int k = 0;k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i,j,k]}({i},{j},{k})");
                Console.WriteLine("\t");
            }
        }
    }
}
int[,,] array = GetArray(2, 2, 2, 99, 10);
PrintArray(array);