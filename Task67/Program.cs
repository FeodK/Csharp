﻿/*
67. Напишите программу,
 которая будет принимать на вход число и возвращать сумму его цифр.
*/
int SumNumber(int n)
{
    if(n==0) 
    return 0;
    else 
    return n%10 + SumNumber(n/10);
}
System.Console.WriteLine(SumNumber(246));
