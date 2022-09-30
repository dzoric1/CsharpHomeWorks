int ReadNumber(string message)
{
   Console.WriteLine(message);
   return Convert.ToInt32(Console.ReadLine());
}
int SumMtoN(int m, int n)
{
   int sum = 0;
   if (n < m)
   {
      for (int i = n; i <= m; i++)
      {
         sum += i;
      }
   }
   else if (n > m)
   {
      for (int i = m; i <= n; i++)
      {
         sum += i;
      }
   }
   else if (n == m) sum = n;
   return sum;
}

int M = ReadNumber("Введите M");
int N = ReadNumber("Введите N");
System.Console.WriteLine($"Сумма чисел в промежутке от {M} до {N} = " + SumMtoN(M, N));