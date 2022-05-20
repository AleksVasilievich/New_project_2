// Напишите программу, которая принимает навход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным.

/*  Вариант 1.

Console.Write(" Введите  цифру, обозначающу день недели -> ");
int dayNum = int.Parse(Console.ReadLine());
if(dayNum == 6 || dayNum == 7)  
{
  Console.Write(" Этот день выходной "); 
}
else if(dayNum != 1 && dayNum != 2 && dayNum != 3 && dayNum != 4 && dayNum != 5 && dayNum != 6 && dayNum != 7)
{
  Console.Write(" Введено не верное значение  ");
}
else 
{
  Console.Write(" Этот день не выходной  ");
}

*/   //Вариант 2


Console.Write(" Введите  цифру, обозначающу день недели -> ");
var dayNum = Convert.ToInt32(Console.ReadLine());
if (dayNum == 6 || dayNum == 7)
{
    Console.Write(" Этот день выходной ");
}
else if (dayNum < 1 || dayNum > 7)
{
    Console.Write(" Введено не верное значение  ");
}
else
{
    Console.Write(" Этот день не выходной  ");
}
            
     // Вариант 3.
/*

Console.Write(" Введите  цифру, обозначающу день недели -> ");
var dayNum = Convert.ToInt32(Console.ReadLine());
string[] isWeekend = { "нет", "нет", "нет", "нет", "нет", "да", "да", };
if (dayNum > 0 && dayNum < 8)
{
    Console.WriteLine(isWeekend[dayNum - 1]);
}
*/