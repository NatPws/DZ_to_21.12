// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


int[,] Create2DArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}
// с этого момента не работает, не получается 
/* int[,] NewArray(int[,] array)

{
    int min = array[1, 1];
    int max = array[1, 1];
    int minstr = 0;
    int maxstr = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minstr = i;
            }

        }
    }

    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > max)
            {
                max = array[i, j];
                maxstr = i;
            }
        }
    }

    Console.WriteLine("Меняем местами строки {0} и {1} строку", minstr + 1, maxstr + 1);
}
int[] temp = new int[4];

for (int i = minstr, j = 0, k = 0; j < 4; j++, k++)
{

    temp[k] = array[i, j];

}

for (int j = 0; j < 4; j++)
{
    array[minstr, j] = array[maxstr, j];
}

for (int j = 0; j < 4; j++)
{
    array[maxstr, j] = temp[j];
}

void PrintIntArray(int[,] array);
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
 */
int[,] myArray = Create2DArray(4, 4, 0, 9);
Print2DArray(myArray);
System.Console.WriteLine();
/* PrintIntArray(NewArray(array)); */
