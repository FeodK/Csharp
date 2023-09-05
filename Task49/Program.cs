/*
Задайте двумерный массив. Найдите элементы,
 у которых оба индекса чётные, и замените эти элементы на их квадраты.
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

int[,] Double2DArray(int[,] array)
{
    int cols = array.GetLength(0);
    int rows = array.GetLength(1);

    int[,] result = new int[cols, rows];
    for(int i=0; i<cols; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            if(i%2==0 && j%2==0)
            {
                result[i,j] = array[i,j]*array[i,j];
            }
            else result[i,j] = array[i,j];
        }
    }
    return result;
}

int[,] randomArray = GetRandom2DArray(5,5,10);
Print2DArray(randomArray);
System.Console.WriteLine();
int[,] newArray = Double2DArray(randomArray);
Print2DArray(newArray);
