/* Задача 21. Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите X1: ");
int userX1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите X2: ");
int userX2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y1: ");
int userY1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y2: ");
int userY2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z1: ");
int userZ1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z2: ");
int userZ2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt((userX2-userX1)*(userX2-userX1)+(userY2-userY1)*
(userY2-userY1)+(userZ2-userZ1)*(userZ2-userZ1));
distance = Math.Round(distance, 2);
Console.WriteLine($"Расстояние равно: {distance}");


