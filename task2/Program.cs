// Задать массив на 10 целых чисел. Написать программу, которая определяет количество четных чисел в массиве 

int[] array = { 1, 36, 17, 10, 11, 13, 20, 22, 48, 29 };
int size = 10;
int index = 0;
int count = 0;
for (index = 0; index < size; index++)
    {
    if (array[index] % 2 == 0)
        {
        count = count + 1;
        }
    }
Console.WriteLine($"Количество четных чисел в массиве: {count}");