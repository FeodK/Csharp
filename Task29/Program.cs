/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
int[] GetRandomArray()
{
    System.Console.WriteLine("Введите число кол-во элементов массива: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[number];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,99);
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

