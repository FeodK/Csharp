/*
Напишите программу,
 которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int number1 = number % 10;
int number2 = number / 100;
int number3 = number2 * 10;

Console.WriteLine(number3 + number1);
