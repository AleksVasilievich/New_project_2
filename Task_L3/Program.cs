// Напишите программу ,которая принимает на вход число(A)
// и выдаёт сумму чисел от 1до  A.
// 7 -> 28
Console.WriteLine(" Введите натуральное число ");
int num = int.Parse(Console.ReadLine());

int GetSumNambers(int namber)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}
int sumResult = GetSumNambers(num);

Console.WriteLine($"Сумма чисел от 1 до {num} = {GetSumNambers(num)}");

//int sumResult = GetSumNambers(num);


// int sum = 0;
// for (int i = 1; i <= num; i++)
// {
//     sum = sum + i;
// }
// Console.WriteLine($"Сумма чисел от 1 до {num} = {sum}");
