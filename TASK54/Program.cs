/* Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива. */


/*  Создание случайного двумерного массива */
int[,] GetArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random arrayRandomValue = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = arrayRandomValue.Next(0, 10);
        }
    }
    return array;
}

/*  Метод печати массива */
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            Console.Write("{0,6}", array[i, j]);
        }
        Console.WriteLine();
    }
}


/* Метод сортировки строк массива */
int[,] SortArrayRows(int[,] array)
{
    int temp = 0;
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int l = 0; l < array.GetLength(1); l++)
        {
            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int j = i + 1; j < array.GetLength(1); j++)
                {
                    if (array[k, i] < array[k, j])
                    {
                        temp = array[k, j];
                        array[k, j] = array[k, i];
                        array[k, i] = temp;
                    }
                }
            }
        }

    }
    return array;
}

int[,] array = GetArray(6, 6);
Console.WriteLine("Изначально заданный массив:");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Элементы массива сотрированы по убыванию:");
int[,] tempArray = SortArrayRows(array);
PrintArray(tempArray);