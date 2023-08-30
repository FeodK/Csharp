/* Задайте одномерный массив, заполненный случайными числами.\
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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


int SumNumber(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    return sum;

}

PrintArray(uArray);
System.Console.WriteLine();
System.Console.Write(SumNumber(uArray));
