// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве. А(3,6);В(2,1)-> 5,09

Console.WriteLine("Введите координаты А : ");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты В : ");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());

double sum = (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);
double result = Math.Sqrt(sum);

Console.WriteLine($"{sum:F2}");
