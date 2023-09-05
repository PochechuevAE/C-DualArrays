// 5!=5*4*3*2*1
/*
System.Console.WriteLine(Factorial(5));

double Factorial(int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}

for (int i = 1; i < 40; i++)
{
    System.Console.WriteLine($"Факториал {i}! = {Factorial(i)}");
} 
*/
// Последовательность фибаначи
//f(1) = 1
//f(2) = 1
//f(n) = f(n-1)+f(n-2)

double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 10; i++)
{
    System.Console.WriteLine($"f{i} = {Fibonacci(i)}");
}