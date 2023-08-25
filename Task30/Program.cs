/*
Напишите программу, которая выводит массив из 8 элементов,
 заполненный нулями и единицами в случайном порядке.
*/
int[] GetRandomArray()
{
    int[] array = new int[8];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,2);
    }
    return array;
}
int[] uArray = GetRandomArray();
void PrintArray(int[] arrayToPrint)
{
   System.Console.Write("[ ");
   for (int i = 0; i < arrayToPrint.Length; i++)
   {
    System.Console.Write(arrayToPrint[i] + " ");
   }
   System.Console.Write("]");
}

PrintArray(uArray);