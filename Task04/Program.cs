/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
*/
Console.WriteLine("Введите три числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int max = 0;
if(number1 > number2)
{
    max = number1;
}
else
{
    max = number2;
}
if(max > number3)
{
    Console.WriteLine("max = " + max);
}
else{
    max = number3;
    Console.WriteLine("max = " + max);
}