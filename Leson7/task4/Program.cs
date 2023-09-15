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

//Улучшение рекурсии

int PowerRecMath(int a, int n)
{
    if (n == 0)
    {
        return 1;
    }

    else if (n % 2 == 0)
    {
        return PowerRecMath(a * a, n / 2);
    }
    
    else
    {
        return PowerRecMath(a, n - 1) * a;
    }
}

System.Console.WriteLine($"Цикл");
System.Console.WriteLine(PowerFor(2, 10));
System.Console.WriteLine($"Рекурсия");
System.Console.WriteLine(PowerRec(2, 10));
System.Console.WriteLine($"Улучшеная рекурсия");
System.Console.WriteLine(PowerRecMath(2, 10));