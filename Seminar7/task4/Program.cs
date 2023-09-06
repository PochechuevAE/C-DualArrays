/*
Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/
int rows = SetNumber("Строк");
int columns = SetNumber("Колонок");
int [,] matrix = GetMatrix(columns: columns, rows: rows);
PrintMatrix(matrix);
System.Console.WriteLine($"Сумма главной диагонали равна: {GetDiagonal(matrix)}");


int[,] GetMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i, l] = rand.Next(1, 10);
        }
    }

    return matrix;
}

int SetNumber(string message = "")
{
    System.Console.Write($"Введите число {message} : ");
    return Convert.ToInt32(System.Console.ReadLine());
}

void PrintMatrix(int [,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
    
}

int GetDiagonal(int [,] matrix)
{
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
           if (i == l) sum = sum + matrix[i, l];
        }
    }
    
    return sum;
}
    