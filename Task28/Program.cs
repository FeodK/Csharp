/*
Напишите программу, которая принимает на вход число N
 и выдаёт произведение чисел от 1 до N.

4 -> 24
5 -> 120
*/
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Sum(int number)
{
    int sum = number;
    for(int i = 1; i<number; i++)
    {
        sum = sum * i;
    }
    return sum;
}

System.Console.WriteLine(Sum(number));