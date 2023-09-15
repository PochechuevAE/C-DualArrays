// Вычислить число a в степени n

// Решение циклом

int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= a;
    }

    return result;
}

//Решение рекурсией

int PowerRec(int a, int n)
{
    if (n == 0)
    {
        return 1;
    }
    
    else
    {
        return PowerRec(a, n -1) * a;
    }
}

System.Console.WriteLine(PowerFor(2, 10));
System.Console.WriteLine(PowerRec(2, 10));