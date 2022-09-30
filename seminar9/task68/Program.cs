int ReadNumber(string message)
{
   Console.WriteLine(message);
   return Convert.ToInt32(Console.ReadLine());
}

int Akkerman(int n, int m)
{
   if (n == 0)
      return m + 1;
   else
     if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
   else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}

int m = ReadNumber("Введите m");
int n = ReadNumber("Введите n");
System.Console.WriteLine(Akkerman(m, n));