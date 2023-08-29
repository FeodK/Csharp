/*
Найдите произведение пар чисел в одномерном массиве.
 Парой считаем первый и последний элемент, второй и предпоследний и т.д.
  Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
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

int[] ProdPar(int[] array)
{
    int[] array1 = new int[array.Length/2];

    for (int i = 0; i <array.Length/2; i++)
    {
        array1[i] = array[i]*array[array.Length-1-i];
    }

    return array1;

}

PrintArray(uArray);
int[] newArray = ProdPar(uArray);
System.Console.WriteLine();
PrintArray(newArray);