/* 
Задача 49: Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты.
*/
int rows = SetNumber("Строк");
int columns = SetNumber("Колонок");
int [,] matrix = GetMatrix(columns: columns, rows: rows);
PrintMatrix(matrix);
System.Console.WriteLine($"Преобразованая матрица выглядит так:");
NewMatrix(matrix);
PrintMatrix(matrix);

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

void NewMatrix(int [,] matrix)
{  
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {                
            if (i % 2  == 0 && l % 2 == 0)
            {
                matrix[i, l] *= matrix[i, l];
            }
        }
    }
}