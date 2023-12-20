// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементами массива

double[] arr = { 8.6, 1.2, 4.8, 9.29, 3.4 };

Console.WriteLine("Minimum number is " + arr.Min());
Console.WriteLine("Maximum number is " + arr.Max());
double result = arr.Max() - arr.Min();
Console.WriteLine("Разница = " + result);

