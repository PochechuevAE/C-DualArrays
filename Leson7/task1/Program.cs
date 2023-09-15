// Создать строку с числами от a до b, a <= b

// Решение циклами

string NumberFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

//Решение через рекурсию

string NumbersRec(int a, int b)
{
    if (a <= b) 
    {
        return $"{a} " + NumbersRec(a + 1, b);
    }
    else
    {
        return String.Empty;
    }
}   

System.Console.WriteLine(NumberFor(1, 10));
System.Console.WriteLine(NumbersRec(1, 10));