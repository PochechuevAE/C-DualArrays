// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int rows = SetNumber("Строк");
int columns = SetNumber("Колонок");

var matrix = GetMatrix(rows: rows, columns: columns);
PrintArray(matrix);
System.Console.WriteLine();

Dictionary<int, int> dict = new Dictionary<int, int>(); //пробегает по массиву 1 раз и считает сколько и каких элементов
     for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int l = 0; l < matrix.GetLength(1); l++)
            {
                if (dict.ContainsKey(matrix[i, l]))
                {
                    dict[matrix[i, l]]++;
                }
                else
                {
                    dict.TryAdd(matrix[i, l], 1);
                }
            }
            
        }

    foreach(var item in dict)
    {
        System.Console.WriteLine($"Элемент {item.Key} кол-во {item.Value} ");
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