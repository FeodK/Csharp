/*
Напишите программу замена элементов массива:
 положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

Console.Clear();

int[] GetRandomArray()
{
    System.Console.WriteLine("Введите число кол-во элементов массива: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[number];
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
        Console.Write ( ", ");
       }
   }
   System.Console.Write("]");
}

int[] ChangeArray(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        array[i] *=-1;
    }
    return array;
}

PrintArray(uArray);
System.Console.WriteLine();
PrintArray(ChangeArray(uArray));