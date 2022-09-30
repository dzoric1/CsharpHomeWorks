int ReadNumber(string message)
{
   Console.WriteLine(message);
   return Convert.ToInt32(Console.ReadLine());
}

void PrintNto1(int n)
{
   for (int i = n; i > 0; i--)
   {
      System.Console.Write(i + " ");
   }
}

int number = ReadNumber("Введите N");
PrintNto1(number);