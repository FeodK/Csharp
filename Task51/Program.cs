/*
Задайте двумерный массив. Найдите сумму элементов,
 находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
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

void Print2DArray(int[,] ArrayToPrint)
{
    System.Console.Write($"[ ]\t");
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

int SumArray(int[,] array)
{
    int result = 0;
    int cols = array.GetLength(0);
    int rows = array.GetLength(1);
    int size = 0;

    if(cols > rows) size = rows;
    else size = cols;

    for (int i = 0; i < size; i++)    
    {
        result += array[i,i];
    }

    return result;;
}

int[,] randomArray = GetRandom2DArray(5,5,10);
Print2DArray(randomArray);
System.Console.WriteLine(SumArray(randomArray));