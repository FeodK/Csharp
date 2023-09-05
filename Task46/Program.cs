/*
Задайте двумерный массив размером m×n,
 заполненный случайными целыми числами.
*/

Console.Clear();

int[,] GetRandom2DArray(int rowNumber, int colNumber, int deviation)
{
    int[,] result = new int[rowNumber, colNumber];
    for(int i=0; i<rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i,j] = new Random().Next(-deviation, deviation);
        }
    }
    return result;
}

void Print2DArray(int[,] ArrayToPrint)
{
    System.Console.Write($"[]\t");
    for (int i = 0; i < ArrayToPrint.GetLength(1); i++)
    {
        System.Console.Write($"[{i}]\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < ArrayToPrint.GetLength(0); i++)
    {
        System.Console.Write($"[{i}]\t");        
        for (int j = 0; j < ArrayToPrint.GetLength(1); j++)
        {
            System.Console.Write(ArrayToPrint[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] randomArray = GetRandom2DArray(5,5,10);
Print2DArray(randomArray);