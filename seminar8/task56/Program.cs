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
         Console.Write($"{matrix[i, j]}  ");
      }
      Console.WriteLine();
   }
}

int SumLineMatrix(int[,] matrix, int i)
{
   int sumLine = matrix[i, 0];
   for (int j = 1; j < matrix.GetLength(1); j++)
   {
      sumLine += matrix[i, j];
   }
   return sumLine;
}
void PrintMinSumLine(int[,] matrix)
{
   int minSumLine = 0;
   int sumLine = SumLineMatrix(matrix, 0);
   for (int i = 1; i < matrix.GetLength(0); i++)
   {
      int tempSumLine = SumLineMatrix(matrix, i);
      if (sumLine > tempSumLine)
      {
         sumLine = tempSumLine;
         minSumLine = i;
      }
   }
   System.Console.WriteLine($"Строка с наименьшей суммой: {minSumLine + 1}, которая равна {sumLine}");
}


int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
int[,] matr = GetMatrix(m, n, 0, 10);
PrintMatrix(matr);
PrintMinSumLine(matr);
