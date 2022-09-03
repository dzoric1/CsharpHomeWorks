Console.WriteLine("Введите первое число:");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число:");
int numberC = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Наибольшее число - " + Math.Max(numberA, Math.Max(numberB, numberC)));