int ReadNumber(string message)
{
   Console.WriteLine(message);
   return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = -10, int rightRange = 10)
{
   int[,] matrix = new int[rowsCount, columnsCount];

   Random rand = new Random();

   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         matrix[i, j] = rand.Next(leftRange, rightRange + 1);
      }
   }

   return matrix;
}

void PrintMatrix(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         Console.Write($"{matrix[i, j]}\t");
      }
      Console.WriteLine();
   }
}

void PrintAverageColumnMatrix(int[,] matrix)
{

   for (int j = 0; j < matrix.GetLength(1); j++)
   {
      double avSum = 0;
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
         avSum += matrix[i, j];
      }
      System.Console.WriteLine(($"Среднее арифметическое {j + 1} столбца: {avSum / matrix.GetLength(0):0.00}"));
   }
}

int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);
PrintAverageColumnMatrix(matr);