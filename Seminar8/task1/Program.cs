// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int rows = SetNumber("Строк");
int columns = SetNumber("Колонок");

int [,] matrix = GetMatrix(columns: columns, rows: rows);
PrintArray(matrix);
ChengeRows(matrix);
System.Console.WriteLine($"Новый массив равен: ");
PrintArray(matrix);

int SetNumber(string message = "")
{
    System.Console.Write($"Введите число {message} : ");
    return Convert.ToInt32(System.Console.ReadLine());
}

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

void PrintArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++) 
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++) 
         {
              System.Console.Write($"{matr[rows, columns]} ");
         }
        System.Console.WriteLine();
    }
}

void ChengeRows(int [,] matr)
{
    int lastRow = matrix.GetLength(0) -1;
    for (int i = 0; i < matr.GetLength(1); i++)
    {
       int temp = matrix[lastRow, i];
       matrix[lastRow, i] = matrix[0, i];
       matr[0, i] = temp;
    }
}