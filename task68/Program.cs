int Ackermann(int m, int n)
{
    if(m >=0 && n>=0)
    {
       if (m == 0) return n + 1;
    else
    {
        if (m > 0 && n == 0) return Ackermann(m - 1, 1);
        else return Ackermann(m - 1, Ackermann(m, n - 1));
    } 
    }
    else return 0;
}
Console.WriteLine("Введите число m из A(m,n)");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n из A(m,n)");
int n = Convert.ToInt32(Console.ReadLine());
int a = Ackermann(m, n);
Console.WriteLine($"A({m},{n}) = {a}");


