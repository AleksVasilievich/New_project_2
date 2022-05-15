// Напишите программу,которая на вход принимает два числа 
// и проверяет,является ли первое число квадратом второго.
Console.Write("Введите первое число -> ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число -> ");
int num2 = int.Parse(Console.ReadLine());
int result = num2 * num2;
if (result == num1) Console.Write("Первое число является квадратом второго");

else Console.Write("Первое число не является квадратом второго");


//bool result = num2 * num2 == num1;
//Console.WriteLine(result "Да" ? : "Нет");
