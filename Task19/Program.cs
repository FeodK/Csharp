/*
Напишите программу, которая принимает на вход пятизначное число и проверяет,
 является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
System.Console.WriteLine("Введите  пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum =0;
int n = 0;

if(number>9999 && number<999999)
{
    for(n =number; number!=0; number = number/10)
    {
    int r = number %10;
    sum = sum *10 + r;
    }
    if (n == sum)
    {
        System.Console.WriteLine("да");
    }
    else
    {
        System.Console.WriteLine("нет");
    }
}
else
{
    System.Console.WriteLine("Введите пятизначное число");
}