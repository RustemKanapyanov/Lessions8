/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
 Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)

45(1,0,0) 53(1,0,1)
 */


void Fill3DArrayRandomNumbers(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(0, 100);
                for (int x = 0; x < i; x++)
                {
                    for (int y = 0; y < j; y++)
                    {
                        for (int z = 0; z < k; z++)
                        {
                            while (array[i, j, k] == array[x, y, z])
                                Fill3DArrayRandomNumbers(array);
                        }
                    }
                }
            }
        }
    }
}


void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("[ ");
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + " ");
            }
            Console.Write("]");
            Console.WriteLine("");
        }
        Console.WriteLine("");
    }
}

int[,,] numbers = new int[2, 3, 4];
Fill3DArrayRandomNumbers(numbers);
PrintArray(numbers);


int[] mass = new int[5];
FillArrayRandomNumbers(mass);
PrintArray(mass);
void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
        for (int j = 0; j < i; j++)
        {
            while (array[i] == array[j])
                FillArrayRandomNumbers(array);
        }
    }
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine("");
}