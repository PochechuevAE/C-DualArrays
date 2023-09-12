/* Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/
System.Console.WriteLine(PrintNumbers(1, 100));

string PrintNumbers(int startNumber, int endNumber)
{
    if (startNumber == endNumber) 
    {
        return startNumber.ToString();
    }
    
    return startNumber + " " + PrintNumbers(startNumber + 1, endNumber);
}
