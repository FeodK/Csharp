/*
Напишите цикл,
 который принимает на вход два числа (A и B)
  и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

*/
Console.WriteLine("Введите числа: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

int Number(int number1, int number2)
{
  int sum = 1;
  while(number2 !=0)
  {
    sum = sum * number1;
    number2 = number2 - 1;
  }
  return sum;
}
System.Console.WriteLine(Number(numberA, numberB));