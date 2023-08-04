/*
Напишите программу, которая выводит случайное число из отрезка [10, 99]
 и показывает наибольшую цифру числа. 
78 -> 8
12-> 2
85 -> 8
*/

int number = new Random().Next(10, 100);
Console.WriteLine(number);

int number1 = number / 10;
int number2 = number % 10;

if(number1 > number2)
{
    Console.WriteLine($"Наибольшая цифра числа {number} - {number1}");
}
else
{
    Console.WriteLine($"Наибольшая цифра числа {number} - {number2}");
}