void PrintNumbers(int M, int N)
{
    if (M == N)
    {
        Console.Write($"{N}. ");
        Console.WriteLine();
        return;
    }
    if (N < 1)
    {
        Console.WriteLine("Введите числа больше 0");
        return;
    }
    if (M > 0) Console.Write($"{M}, ");
    PrintNumbers(M + 1, N);
}


Console.WriteLine("Введите начальное число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число N");
int n = Convert.ToInt32(Console.ReadLine());
PrintNumbers(m, n);