//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

int[,] myArray = Create2DArray(5, 5, 0, 9);

Print2DArray(myArray);
System.Console.WriteLine("Введите число а: ");
Console.ReadLine();
System.Console.WriteLine("Введите число b: ");
Console.ReadLine();

int a = new int { };
int b = new int { };

// дальше надо доделать, не работает пока
/* {
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (a == j)
            {
                return a;
            }
            else if (b == j)
            {
                return b;
            }
            else
            {
                Console.WriteLine("такого элемента нет");
            }
        }
        if (a == i)
        {
            return a;
        }
        else if (b == i)
        {
            return b;
        }
        else
        {
            Console.WriteLine("такого элемента нет");
        }
    }
}
 */
