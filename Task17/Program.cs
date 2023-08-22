/* Напишите программу, которая принимает на вход координаты точки (X и Y),
 причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
  в которой находится эта точка.*/

Console.WriteLine("Введите координаты X и Y: ");
int userX = Convert.ToInt32(Console.ReadLine());
int userY = Convert.ToInt32(Console.ReadLine());

if(userX>0 && userY>0)
{
    System.Console.WriteLine($"Точка {userX} : {userY} находятся в первой четверти");
}
else if(userX<0 && userY>0)
{
    System.Console.WriteLine($"Точка {userX} : {userY} находятся во второй четверти");
}
else if(userX<0 && userY<0)
{
    System.Console.WriteLine($"Точка {userX} : {userY} находятся в третьей четверти");
}
else
{
    System.Console.WriteLine($"Точка {userX} : {userY} находятся в чветвертой четверти");
}
