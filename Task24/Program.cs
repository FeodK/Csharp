/*
Напишите программу,
 которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
*/
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// int sum = 0;
// for(int i=1; i<=number; i++)
// {
//     sum += i;
// }
// System.Console.WriteLine(sum);

int SumOfNumber(int number)
{
    int sum = 0;
    for(int i=1; i<=number; i++)
    {
    sum += i;
    }
    return sum;
}

System.Console.WriteLine(SumOfNumber(number));