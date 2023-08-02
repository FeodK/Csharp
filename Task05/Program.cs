/*
Напишите программу, которая на вход принимает одно число (N),
а на выходе показывает все целые числа в промежутке от -N до N.
*/ 

Console.WriteLine("Напишите число");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = -number; i <= number; i++)
{
    Console.Write(i+" ");
}