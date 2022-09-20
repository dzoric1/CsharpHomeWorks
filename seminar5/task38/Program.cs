// Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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

int DiffMaxMinNumbers(int[] arr)
{
   int max = arr[0];
   int min = arr[0];
   for (int i = 0; i < arr.Length; i++)
   {
      if (arr[i] > max)
      {
         max = arr[i];
      }
      if (arr[i] < min)
      {
         min = arr[i];
      }
   }
   int diff = max - min;
   return diff;
}

Random rand = new Random();
int randomSize = rand.Next(4, 15);
int[] array = GetArray(randomSize, 1, 1000);
System.Console.WriteLine(string.Join(" ", array));
int diffMaxMin = DiffMaxMinNumbers(array);
System.Console.WriteLine($"Разница между наибольшим и наименьшим числом = {diffMaxMin}");

