/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/
System.Console.WriteLine(GetSum(453));

int GetSum(int num)
{
    if (num == 0) 
    {
        return num;
    }
    
    return num % 10 + GetSum(num / 10);
}
