/* Задача 55 Задайте двумерный  массив 
Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно 
программа должна вывести сообщение для пользователя. */

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(leftRange, rightRange);
        }
    }
    return matrix;
}

void PrntMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] GetTMatrix(int[,] matrix)
{
    int [,] tmatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
    
    for (int i = 0; i < tmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tmatrix.GetLength(1); j++)
        {
            tmatrix[i, j] = matrix [j, i];
        }
    }
    return tmatrix;
}


int[,] ourMatrix = GetMatrix(3, 4, -10, 10);
PrntMatrix(ourMatrix);
int[,] tmatrix = GetTMatrix(ourMatrix);
Console.WriteLine();
PrntMatrix(tmatrix);