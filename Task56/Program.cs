/*
 Задайте прямоугольный двумерный массив.
  Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке
 и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int[,] GetRandom2DArray(int rowNumber, int colNumber, int deviation)
{
    int[,] result = new int[rowNumber, colNumber];
    for(int i=0; i<rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i,j] = new Random().Next(0, deviation);
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

int[,] randomArray = GetRandom2DArray(6,3,5);
Print2DArray(randomArray);

int FindMinRow(int[,] array)
{
    int minRow = 0;
    int[] sumRowArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRowArray[i] += array[i, j];
        }
    }
    int minSum = sumRowArray[0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (sumRowArray[i] < minSum)
        {
            minSum = sumRowArray[i];
            minRow = i;
        }
    }
    return minRow;
}

int MRow = FindMinRow(randomArray);
System.Console.WriteLine(
    $"Номер строки с наименьшей суммой элементов: {MRow} строка"
    );