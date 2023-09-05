/*
Задайте двумерный массив размером m×n,
 заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
Console.Clear();

double[,] GetRandom2DArray(int rowNumber, int colNumber, int deviation)
{
    double[,] result = new double[rowNumber, colNumber];
    for(int i=0; i<rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i,j] = new Random().NextDouble() + new Random().Next(-deviation, deviation);
        }
    }
    return result;
}

void Print2DArray(double[,] arrayToPrint)
{
    System.Console.Write($"[]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        System.Console.Write($"[{i}]\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        System.Console.Write($"[{i}]\t");        
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            System.Console.Write(Math.Round(arrayToPrint[i,j],1) + "\t");
        }
        System.Console.WriteLine();
    }
}

double[,] randomArray = GetRandom2DArray(3,4,10);
Print2DArray(randomArray);
