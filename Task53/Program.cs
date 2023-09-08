/*
Задайте двумерный массив.
 Напишите программу,
  которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив: 
8 4 2 4
5 9 2 3
1 4 7 2
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

int[,] ResultArray(int[,] array)
{
    int cols = array.GetLength(1);
    int rows = array.GetLength(0);
    int temp = 0;

    for (int i = 0; i < cols; i++)
    {
        temp = array[0, i];
        array[0, i] = array[rows-1, i];
        array[rows-1, i] = temp;
    }
    return array;
}


int[,] randomArray = GetRandom2DArray(3,3,10);
int[,] resArray = ResultArray(randomArray);
Print2DArray(randomArray);
Print2DArray(resArray);