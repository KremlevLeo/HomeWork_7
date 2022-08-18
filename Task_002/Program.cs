/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int row = 3;
int col = 4;
double[,] arr = GenArray(row, col);
Console.Write("Enter the index of the position separated by a space, where the first digit is the line, the second column: ");
int[] coordinatys = GetCoordinates();
if (coordinatys[0] > arr.GetLength(0) || coordinatys[1] > arr.GetLength(1))
{
    PrintArray(arr);
    Console.WriteLine($"\n{coordinatys[0]} {coordinatys[1]} -> This index does not exist.");
}
else
{
    PrintArray(arr);
    Console.WriteLine($"\n {arr[coordinatys[0], coordinatys[1]]}");
}

double[,] GenArray(int row, int col)
{
    double[,] arr = new double[row, col];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Convert.ToDouble(rnd.Next(-100, 101) / 10.0);
        }
    }
    return arr;
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:F1}\t");
        }
        Console.WriteLine();
    }
}
int[] GetCoordinates()
{
    int coordinCount = 0;
    Console.Write("b, k separated by spaces: ");
    string[] input = Console.ReadLine().Split();
    int[] coordinatуs = new int[input.Length];
    for (int i = 0; i < coordinatуs.Length; i++)
    {
        coordinatуs[i] = int.Parse(input[i]);
    }
    return coordinatуs;
}