/*
Напишите программу, которая на вход принимает два числа A и B,
 и возводит число А в целую степень B с помощью рекурсии.
*/
int result = SumNumber(2,5);

int SumNumber (int n, int m)
{   
    if (m==1)
    return n;
    else
    return n*SumNumber(n, m-1);
}
System.Console.WriteLine(result);
