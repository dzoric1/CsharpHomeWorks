// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите степень");
int power = Convert.ToInt32(Console.ReadLine());

if (power > 0)
{
   int result = 1;

   while (power > 0)
   {
      result = result * number;
      power = power - 1;
   }

   System.Console.WriteLine(result);
}
else
{
   System.Console.WriteLine("Степень не натуральное число");
}