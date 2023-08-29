/*
Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
 Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
 сумма положительных чисел равна 29, сумма отрицательных равна -20.*/

int[] GetRandomArray()
{
    int[] array = new int[12];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9,9);
    }
    return array;
}

int[] uArray = GetRandomArray();

void PrintArray(int[] arrayToPrint)
{
   System.Console.Write("[ ");
   for (int i = 0; i < arrayToPrint.Length; i++)
   {
    System.Console.Write(arrayToPrint[i]);
    if (i<arrayToPrint.Length - 1)
       {
        Console.Write (arrayToPrint[i] + ", ");
       }
   }
   System.Console.Write("]");
}

int PositveNums(int[] array)
{
    int sum=0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]>0)
        {
            sum += array[i];
        }
    }

    return sum;
}


int NegativeNums(int[] array)
{
    int sum = 0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]<0)
        {
            sum += array[i];
        }
    }

    return sum;
}

PrintArray(uArray);
System.Console.WriteLine($"сумма положительных чисел равна {PositveNums(uArray)}, сумма отрицательных равна {NegativeNums(uArray)}");
