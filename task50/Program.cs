// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите номер строки");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер стобца");
int column = Convert.ToInt32(Console.ReadLine());


if(line>5 || column>5)Console.WriteLine($"[{line},{column}] ->Такого элемента в массиве нет.");
else 
{
    double[,] array2dRandom = Array2dRandom(5,5,-50,99);
    Console.WriteLine($"{array2dRandom[line-1,column-1]}");
}


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

// void PrintMatrix(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1)-1) Console.Write($"{matrix[i, j],6} ");
//             else Console.Write($"{matrix[i, j],6} ");
//         }
//         Console.WriteLine("|");
//     }
// }


