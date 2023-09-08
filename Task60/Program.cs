/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
 Напишите программу, которая будет построчно выводить массив,
  добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

*/

Console.Clear();

int[,,] MyArray = GetRandom3DArray(2,2,2);
Print3DArray(MyArray);

int[,,] GetRandom3DArray(int x, int y, int z)
{
    int[,,] result = new int[x, y, z];
    for(int i=0; i<result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k <result.GetLength(2); k++)
            {
                result[i,j,k] = new Random().Next(10, 100);
            }
        }
    }
    return result;
}

void Print3DArray(int[,,] ArrayToPrint)
{

for(int i=0; i<ArrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < ArrayToPrint.GetLength(1); j++)
        {
            for (int k = 0; k <ArrayToPrint.GetLength(2); k++)
            {
                Console.WriteLine(ArrayToPrint[i,j,k] + $"({i},{j},{k})"); 
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}