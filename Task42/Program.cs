/*
Напишите программу,
 которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

Console.Clear();

Console.WriteLine("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());

string Number (int a)
{
    string res = string.Empty;
    int temp = 0;

    for(int i =a; i>0; i /=2)
    {
        temp = i%2;
        res = temp + res;
    }

    return res; 
}

string result = Number(num);

System.Console.WriteLine(result);