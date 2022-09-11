/* Задача 57: Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных
 */

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

void PrintRepeatsofElements(int[,] matrix)
{
    int[] repeats = new int[10];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            /*  int index = matrix[i,j];
             repeats[index]++; */
            repeats[matrix[i, j]]++;
        }
    }
    for (int i = 0; i < repeats.Length; i++)
    {
        if (repeats[i] > 0)
        {
            Console.WriteLine($"Количество повторений {i} = {repeats[i]}");
        }
    }
}

int[,] ourMatrix = GetMatrix(3, 4, 0, 9);
PrntMatrix(ourMatrix);
Console.WriteLine();
PrintRepeatsofElements(ourMatrix);