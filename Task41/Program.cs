/*
Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Clear();

System.Console.WriteLine("Введите число кол-во элементов массива: ");
int uNumber = Convert.ToInt32(Console.ReadLine());

int[] FillArray(int number)
{
    int[] array = new int[number];
    System.Console.WriteLine("Задайте массив: ");
    for (int i = 0; i<array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int[] uArray = FillArray(uNumber);

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

int Count(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0) count+=1;
    }

    return count;
}

int count = Count(uArray);

PrintArray(uArray);
System.Console.WriteLine();
System.Console.WriteLine(count);