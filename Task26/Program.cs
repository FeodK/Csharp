/*
Напишите программу, которая принимает на вход число
 и выдаёт количество цифр в числе.

456 -> 3
78 -> 2
89126 -> 5
*/
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Quantity(int number)
{
    int sum =0;
    while(number>0)
    {
        sum += 1;
        number = number/10;
    }
    return sum;
}
System.Console.WriteLine(Quantity(number));
