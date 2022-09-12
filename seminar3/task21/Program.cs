System.Console.WriteLine("Введите координаты первой точки (х,у,z)");
System.Console.Write("Xa = ");
double x1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ya = ");
double y1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Za = ");
double z1 = Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine("Введите координаты второй точки (х,у,z)");
System.Console.Write("Xb = ");
double x2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Yb = ");
double y2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Zb = ");
double z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

System.Console.WriteLine($"{result:f2}");