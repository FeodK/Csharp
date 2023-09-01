/*
Напишите программу, которая принимает на вход три числа и проверяет,
 может ли существовать треугольник с сторонами такой длины.
*/

Console.WriteLine("Введите три числа: ");

int[] FillArray()
{
    int[] array = new int[3];
    for (int i = 0; i<array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

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

bool Existence(int[] array)
{
    
    if(array[0] + array[1] > array[2]
    && array[1] < array[0] + array[2]
    && array[0] < array[1] + array[2]) return true;
    else return false;
    
}
int[] uArray = FillArray();
bool result = Existence(uArray);
PrintArray(uArray);
System.Console.WriteLine();
System.Console.WriteLine(result);