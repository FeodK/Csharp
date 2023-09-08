/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

Console.Clear();

int[,] CreateArray(int a, int b)
{
    int[,] array = new int[a,b];
    int size =4;
    int value = 1;

    int startI = 0;
    int startJ = 0;

    int endI = size - 1;
    int endJ = size - 1;

    while(startI <= endI && startJ <= endJ)
    {
        for(int i = startJ; i <= endJ; i++)
        {
            array[startI, i] = value;
            value++;
        }
        startI++;

        for (int i = startI; i <= endI; i++)
        {
            array[i, endJ] = value;
            value++;
        }
        endJ--;

        for (int i = endJ; i >= startJ; i--)
        {
            array[endI, i] = value;
            value++;
        }
        endI--;

        for (int i = endI; i >= startI; i--)
        {
            array[i, startJ] = value;
            value++;
        }
        startJ++;
    }
    return array;
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

int[,] myArray = CreateArray(4,4);
Print2DArray(myArray);