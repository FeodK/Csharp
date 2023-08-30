/*
Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.Clear();

System.Console.WriteLine("Введите число кол-во элементов массива: ");
int usNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Задайте границы массива: ");
int uMin = Convert.ToInt32(Console.ReadLine());
int uMax = Convert.ToInt32(Console.ReadLine());


int[] GetRandomArray(int number, int min, int max)
{
    int[] array = new int[number];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

int[] uArray = GetRandomArray(usNumber, uMin, uMax);


void PrintArray(int[] arrayToPrint)
{
   System.Console.Write("[ ");
   for (int i = 0; i < arrayToPrint.Length; i++)
   {
    System.Console.Write(arrayToPrint[i]);
    if (i<arrayToPrint.Length - 1)
       {
        Console.Write ( ", ");
       }
   }
   System.Console.Write("]");
}


int CountPositiveNumber(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length-1; i++)
    {
        if (array[i]%2==0)
        {
            sum +=1;
        }
    }
    return sum;

}

PrintArray(uArray);
System.Console.WriteLine();
System.Console.Write(CountPositiveNumber(uArray));