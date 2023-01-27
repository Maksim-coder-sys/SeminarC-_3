//Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
//между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату Х точки А");
int AX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки А");
int AY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки А");
int AZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Х точки B");
int BX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B");
int BY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки B");
int BZ = Convert.ToInt32(Console.ReadLine());

double rezult = Math.Sqrt((Math.Pow((AX-BX), 2) + Math.Pow((AY-BY), 2) + Math.Pow((AZ-BZ), 2)));
rezult = Math.Round(rezult, 2);
Console.WriteLine(rezult);
