// Напишите программу, которая принимает навход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным.

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