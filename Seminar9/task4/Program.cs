/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

System.Console.WriteLine(POW(2, - 1));

double POW(double num, double degree)
{
    if (degree == 0)
    {
        return 1;
    }
    if (num == 1)
    {
        return num;
    }
    if (degree < 0)
    {
        return 1 / (num * POW(num, degree + 1)); 
    }
    return num * POW(num, degree - 1);
}