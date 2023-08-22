/*
Напишите программу,
 которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
*/
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for(int i =1; i <= number; i++)
{
    int result = i*i;
    System.Console.WriteLine(result);
}