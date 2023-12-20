// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементами массива

double[] array = { 3.2, 8.4, 5.1, 1,9, 6.3};
int size = 5;
int i = 0;
double maxNumber = 0;
double minNumber = 0;
double diff = 0;
{
    for (i = 0; i < size; i++)
    {
    if (array[i] > array[i + 1])
        {
        maxNumber = array[i];
        }
        else
        {
        minNumber = array[i];
        }
    }

 diff = maxNumber - minNumber;
}

Console.WriteLine($"Разница между максимальным числом {maxNumber} и минимальным числом {minNumber} в массиве составляет: {diff}"); 