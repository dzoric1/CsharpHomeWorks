// Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int leftRange, int rightRange)
{
   int[] arr = new int[size];
   Random rand = new Random();
   for (int i = 0; i < size; i++)
   {
      arr[i] = rand.Next(leftRange, rightRange + 1);
   }
   return arr;
}

int CountEvenNumber(int[] arr)
{
   int count = 0;
   for (int i = 0; i < arr.Length; i++)
   {
      if (arr[i] % 2 == 0)
      {
         count++;
      }
   }
   return count;
}
Random rand = new Random();
int randomSize = rand.Next(4, 10);
int[] array = GetArray(randomSize, 100, 999);
System.Console.WriteLine(string.Join(" ", array));
int EvenNumbers = CountEvenNumber(array);
System.Console.WriteLine($"Количество четных чисел = {EvenNumbers}");
