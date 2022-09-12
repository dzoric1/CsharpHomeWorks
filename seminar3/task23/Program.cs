System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
   int i = 1;

   while (number >= i)
   {
      System.Console.Write(Math.Pow(i, 3) + " ");
      i++;
   }
}
else
{
   System.Console.WriteLine("Введите число больше нуля");
}