// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
// как построчно сделать сумму и затем вывести строку с минимальной суммой - у меня не вышло
/* 
void MinSumStr(int[,] array)
{   int number = 0;
    for (int i = 0; i < array.GetLength(0) < 1; i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];  
        }
        if (number < sum)
            {
             sum = number;   
            }
        return number;
    }
}    */

int[,] myArray = Create2DArray(4, 3, 0, 9);
Print2DArray(myArray);
System.Console.WriteLine();
/* Print MinSumStr(int[,] number); */