/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int row = 3;
int col = 4;
double[,] arr = FillArray(row, col);
double[] result = AithmeticAean(arr);
Console.Write("Arithmetic mean of each column: ");
PrintArray(result);

double[] AithmeticAean(double[,] array)
{
    double[] arr = new double[array.GetLength(1)];
    double tmp = 0;
    int count = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            tmp += array[j, i];
            count++;
        }
        arr[i] = tmp / count;
        count = 0;
        tmp = 0;
    }
    return arr;
}

double[,] FillArray(int row, int col)
{
    double[,] arr = new double[row, col];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(0, 10);
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
    return arr;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]:F1}\t");
    }
    Console.WriteLine();
}