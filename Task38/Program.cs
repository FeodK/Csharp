/*
Задайте массив вещественных чисел.
 Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

Console.Clear();

System.Console.WriteLine("Введите число кол-во элементов массива: ");
int usNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Задайте границы массива: ");
int uMin = Convert.ToInt32(Console.ReadLine());
int uMax = Convert.ToInt32(Console.ReadLine());


double[] GetRandomArray(int number, int min, int max)
{
    double[] array = new double[number];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() + new Random().Next(min, max);
    }
    return array;
}

double[] uArray = GetRandomArray(usNumber, uMin, uMax);


void PrintArray(double[] arrayToPrint)
{
   System.Console.Write("[ ");
   for (int i = 0; i < arrayToPrint.Length; i++)
   {
    System.Console.Write(Math.Round(arrayToPrint[i],2));
    if (i<arrayToPrint.Length - 1)
       {
        Console.Write ( ", ");
       }
   }
   System.Console.Write("]");
}


double MinMax(double[] array)
{
    double sum = 0;
    double min = array[0];
    double max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (max<array[i])
        {
            max = array[i];
        }
        if (min>array[i])
        {
            min = array[i];
        }
    }

    sum = max - min;

    return sum; 

}

PrintArray(uArray);
System.Console.WriteLine();
System.Console.Write(Math.Round(MinMax(uArray),2));
