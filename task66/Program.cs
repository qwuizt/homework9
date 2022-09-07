void PrintSumNumbers(int M, int N, int sum)
{
    if (M == N)
    {
        Console.Write($"сумма натуральных чисел {sum + N}.");
        Console.WriteLine();
        return;
    }
    if (N < 1)
    {
        Console.WriteLine("Введите числа больше 0");
        return;
    }
    if (M > 0) PrintSumNumbers(M + 1, N, sum + M);
    else PrintSumNumbers(M+1,N,sum);
}


Console.WriteLine("Введите начальное число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число N");
int n = Convert.ToInt32(Console.ReadLine());
PrintSumNumbers(m, n, 0);
