﻿//Напишите программы,которая на вход 
//принимает число и выдаёт его квадрат.
Console.Write("Введите целое число -> ");
int num = int.Parse(Console.ReadLine());
int numResult = num * num;
Console.Write("Квадрат числа равен -> ");
Console.WriteLine(numResult);
Console.ReadKey();