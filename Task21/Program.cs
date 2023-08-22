/*
Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
System.Console.WriteLine("Введите координаты первой точки");
int userX1 = Convert.ToInt32(Console.ReadLine());
int userY1 = Convert.ToInt32(Console.ReadLine());
int userZ1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты второй точки");
int userX2 = Convert.ToInt32(Console.ReadLine());
int userY2 = Convert.ToInt32(Console.ReadLine());
int userZ2 = Convert.ToInt32(Console.ReadLine());
double s = 0;
s = Math.Sqrt(Math.Pow(userX2-userX1,2) + Math.Pow(userY2-userY1,2) + Math.Pow(userZ2-userZ1,2) );
Console.Write("Расстояние между двумя точками:" + Math.Round(s,2));
