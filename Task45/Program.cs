/*
Напишите программу, которая будет
 создавать копию заданного одномерного массива с помощью поэлементного копирования.
*/
Console.Clear();

System.Console.WriteLine("Введите число кол-во элементов массива: ");
int uNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Задайте массив: ");

int[] FillArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i<array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int[] uArray = FillArray(uNumber);

int[] CopyArray(int[] array)
{
    int[] copyArray = new int [array.Length];

    for(int i = 0; i<array.Length; i++)
    {
        copyArray[i] = array[i];
    }
    return copyArray;
}

int[] newArray = CopyArray(uArray);

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

PrintArray(uArray);
PrintArray(newArray);