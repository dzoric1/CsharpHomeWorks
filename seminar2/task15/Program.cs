// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели:");
int numDay = Convert.ToInt32(Console.ReadLine());

if (numDay > 7 || numDay < 1)
{
   Console.WriteLine("В неделе только семь дней");
}
else if (numDay > 5)
{
   Console.WriteLine("Выходной!)");
}
else
{
   Console.WriteLine("Рабочий :(");
}