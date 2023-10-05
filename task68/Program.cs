int FunctionAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return FunctionAkkerman (m - 1, 1);
    else return FunctionAkkerman (m - 1, FunctionAkkerman (m, n - 1));
}

Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Функция Аккермана равно { FunctionAkkerman (m, n)} ");

