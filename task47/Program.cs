// Задача 47. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите номер строки");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер стобца");
int column = Convert.ToInt32(Console.ReadLine());

double[,] Array2dRandom(int lin, int colum, int max, int min)
{
    double[,] array2d = new double[lin, colum];
    var rnd = new Random();
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            double rndNum =rnd.NextDouble()*(max - min) + min;
            array2d[i,j] = Math.Round(rndNum,1);
        }
    }
    return array2d;
}


void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1)-1) Console.Write($"{matrix[i, j],6} ");
            else Console.Write($"{matrix[i, j],6} ");
        }
        Console.WriteLine("|");
    }
}


double[,] array2dRandom = Array2dRandom(line,column, -45,99);
PrintMatrix(array2dRandom);
