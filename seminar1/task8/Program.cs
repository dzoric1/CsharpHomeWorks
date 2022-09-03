Console.Write("Находим четные числа от 1 до ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 2;

if (number < 2)
{
   Console.WriteLine("Четных чисел в этом интервале нет");
}

while (i <= number)
{
   Console.Write(i + " ");
   i += 2;
}
