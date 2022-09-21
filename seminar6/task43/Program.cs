// Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int ReadNumber(string message)
{
   Console.WriteLine(message);
   return Convert.ToInt32(Console.ReadLine());
}

double[] FindXYPoint()
{
   double k1 = ReadNumber("Введите k1:");
   double b1 = ReadNumber("Введите b1:");
   double k2 = ReadNumber("Введите k2:");
   double b2 = ReadNumber("Введите b2:");
   double[] XYPoint = new double[2];

   if (k1 == k2)
   {
      System.Console.WriteLine("Прямые параллельны");
   }
   else
   {
      XYPoint[0] = (b2 - b1) / (k1 - k2);
      XYPoint[1] = ((k1 * b2) - (k2 * b1)) / (k1 - k2);
   }

   return XYPoint;
}
double[] XY = FindXYPoint();
System.Console.WriteLine(string.Join(" ", XY));