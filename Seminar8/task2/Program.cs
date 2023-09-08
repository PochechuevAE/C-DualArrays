// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
int rows = SetNumber("Строк");
int columns = SetNumber("Колонок");

int [,] matrix = GetMatrix(columns: columns, rows: rows);
PrintArray(matrix);
ChengeMatrix(matrix);
System.Console.WriteLine($"Измененный массив: ");
PrintArray(matrix);

void ChengeMatrix(int [,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            matrix[l, i] = matrix [i, l];
        }
    }
}


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
            matrix[i, l] = rand.Next(1, 50);
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