// Сумма чисел от 1 до n

//Решение циклом

int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++)
    {
        result += i;
    }

    return result;
}

//Решение через рекурсию

int SumRec(int n)
{
    if (n == 0)
    {
        return 0;
    }
    else
    {
        return n + SumRec(n - 1);
    }
}

System.Console.WriteLine(SumFor(10));
System.Console.WriteLine(SumRec(10));