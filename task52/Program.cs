// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrix2DRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0);i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

double[] CreateArrayArithmeticInt(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
     int coll = 0;
    for (int i = 0; i < matrix.GetLength(0);i++)
    {
        coll++;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[j] = Math.Round (array[j] + matrix[i,j])/coll;
            
        }
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i],3}, ");
        else Console.Write($"{array[i],3} ");
    }
    Console.WriteLine("]");
}




int[,] createMatrix2DRndInt = CreateMatrix2DRndInt(4,3,1,9);
double[] createArrayArithmeticInt = CreateArrayArithmeticInt(createMatrix2DRndInt);
PrintArray(createArrayArithmeticInt);

