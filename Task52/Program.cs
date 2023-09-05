/*
 Задайте двумерный массив из целых чисел.
  Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
Console.Clear();

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

void Print2DArray(int[,] arrayToPrint)
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
            System.Console.Write(arrayToPrint[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}

double FindAritnmeticMean(int[,] array)
{
    double sum = 0;
    int n = array.GetLength(1)-1;
    for(int i=0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];  
        } 
        System.Console.WriteLine(Math.Round(sum/n,2));
        sum = 0;
    }
    return sum;
}

int[,] randomArray = GetRandom2DArray(7,5,10);
Print2DArray(randomArray);
FindAritnmeticMean(randomArray);
