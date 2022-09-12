int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
   System.Console.Write($"Введите {i + 1} элемент массива:");
   array[i] = Convert.ToInt32(Console.ReadLine());
}

System.Console.Write("Полученный массив: ");

foreach (int arr in array)
{

   Console.Write(arr + " ");
}