/*
Задайте две матрицы.
 Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.Clear();

int[,] matrix1 = {{2,4}, {3,2}};
int[,] matrix2 = {{3,4}, {3,3}};

int[,] GreatResultMatrix(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int columns1 = matrix1.GetLength(1);
    int rows2 = matrix1.GetLength(0);
    int columns2 = matrix1.GetLength(1);
    
    int[,] result = new int[rows1, columns2];
    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            for (int k = 0; k < columns1; k++)
            {
                result[i,j] += matrix1[i,k] * matrix2[k,j];
            }
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

int[,] resultMatrix = GreatResultMatrix(matrix1, matrix2);
Print2DArray(matrix1);
Print2DArray(matrix2);
System.Console.WriteLine();
Print2DArray(resultMatrix);