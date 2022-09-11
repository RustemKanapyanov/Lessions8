//Задача 53: Задайте двумерный массив 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

void SwapFifstAndLastRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[0, i];
        matrix[0, 1] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = temp;
    }
}
int[,] ourMatrix = GetMatrix(3, 4, -10, 10);
PrntMatrix(ourMatrix);
SwapFifstAndLastRows(ourMatrix);
Console.WriteLine();
PrntMatrix(ourMatrix);