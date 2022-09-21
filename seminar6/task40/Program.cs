// Напишите программу, которая принимает на вход три числа и 
// проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона 
// треугольника меньше суммы двух других сторон.

// int ReadNumber(string message)
// {
//    Console.WriteLine(message);
//    return Convert.ToInt32(Console.ReadLine());
// }

void TriangleTrue(double s1, double s2, double s3)
{
   if (s1 < s2 + s3 && s2 < s1 + s3 && s3 < s1 + s2)
   {
      System.Console.WriteLine($"Треугольник со сторонами {s1}, {s2}, {s3} существует");
   }
   else
   {
      System.Console.WriteLine($"Треугольник со сторонами {s1}, {s2}, {s3} не существует");
   }
}

TriangleTrue(2, 2, 2);
TriangleTrue(2, 8, 2);
TriangleTrue(0.5, 1.2, 1);
