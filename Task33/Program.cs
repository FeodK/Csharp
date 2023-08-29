/*
Задайте массив. Напишите программу, которая определяет,
 присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
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
        Console.Write (arrayToPrint[i] + ", ");
       }
   }
   System.Console.Write("]");
}

System.Console.WriteLine("Enter number: ");
int uNumber = Convert.ToInt32(Console.ReadLine());

bool FindNumber(int[] array, int num)
{
    bool number1 = false;
    for (int i = 0; i < array.Length-1; i++)
    {
        if (array[i]==num)
        {
            number1 = true;
        }
    }
    return number1;

}

PrintArray(uArray);
System.Console.WriteLine();
FindNumber(uArray, uNumber);