// |table[0, 0] | table[0, 1] | table[0, 2] | table[0, 3] | ... |        
// |table[1, 0] | table[1, 1] | table[1, 2] | table[1, 3] | ... |
/*
string[,] table = new string[2, 5]; // Задан массив из строк, 2 это кол-во строк, 5 - кол-во столбцов от нуля до 4
table[1, 2] = "Слово"; // обращение к нужному элементу массива 1 - индекс стоки, 2 - индекс столбца. индексы строк и столбцов меняются от нуля

for (int rows = 0; rows < 2; rows++) //строки от нуля и не больше 2х в данном случае
{
    for (int columns = 0; columns < 5; columns++) //кол-во столбцов не больше 5
    {
        System.Console.WriteLine($"-{table[rows, columns]}-"); // распечатка обращение к элементам через имя массива, индекс строки и столбца
    }
}
*/
// matrix.GetLength(0) - обращение к кол-ву строк (0)
// matrix.GetLength(1) - обращение к кол-ву столбцов (1)

int[,] matrix = new int[3, 4];
/*
for (int rows = 0; rows < matrix.GetLength(0); rows++) 
{
    for (int columns = 0; columns < matrix.GetLength(1); columns++) 
    {
        System.Console.Write($"{matrix[rows, columns]} ");
    }
System.Console.WriteLine();
}
*/
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

PrintArray(matrix);

void FillArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            matr[rows, columns] = new Random().Next(1, 10); // [1, 10) если включить последний, то +1 ставь в конце
        }
    }
}
System.Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);