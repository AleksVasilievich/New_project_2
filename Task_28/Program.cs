// // Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.WriteLine(" Введите натуральное число N ");
int num = int.Parse(Console.ReadLine());

int GetSumNambers(int namber)
{
    int mult = 1;
    for (int i = 1; i <= num; i++)
{
    mult = mult * i;
}
   return mult;
}
int sumResult = GetSumNambers(num);
Console.WriteLine($"Сумма чисел от 1 до {num} = {GetSumNambers(num)}");
