// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int tempNumber = 0;

while (number != 0)
{
   tempNumber = number % 10;
   sum = sum + tempNumber;
   number = number / 10;
}

System.Console.WriteLine("Сумма цифр равна = " + Math.Abs(sum));