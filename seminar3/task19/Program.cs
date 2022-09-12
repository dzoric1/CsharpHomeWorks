System.Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number <= 99999)
{
   int number1 = number / 10000;
   int number2 = (number / 1000) % 10;
   int number4 = (number / 10) % 10;
   int number5 = number % 10;

   if (number1 == number5 && number2 == number4)
   {
      System.Console.WriteLine("Число является палидромом");
   }
   else
   {
      System.Console.WriteLine("Число не является палидромом");
   }
}
else
{
   System.Console.WriteLine("Число не пятизначное");
}