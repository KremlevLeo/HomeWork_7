/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

double[,] FillArray(int row, int col)
{
    double[,] arr = new double[row, col];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Convert.ToDouble(rnd.Next(-100, 101)/10.0);
            Console.Write($"{arr[i, j]:F2}\t");
        }
        Console.WriteLine();
    }
    return arr;
}

Console.Write("Enter number of lines: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter number of columns: ");
int col = int.Parse(Console.ReadLine());
FillArray(row, col);