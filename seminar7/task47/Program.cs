int ReadNumber(string message)
{
   Console.WriteLine(message);
   return Convert.ToInt32(Console.ReadLine());
}

double[,] GetMatrix(int rowsCount, int columnsCount, double leftRange = -10, double rightRange = 10)
{
   double[,] matrix = new double[rowsCount, columnsCount];

   Random rand = new Random();

   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         matrix[i, j] = leftRange + rand.NextDouble() * (rightRange - leftRange);
      }
   }

   return matrix;
}

void PrintMatrix(double[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         Console.Write($"{matrix[i, j]:0.00}\t");
      }
      Console.WriteLine();
   }
}

int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
double[,] matr = GetMatrix(m, n);
PrintMatrix(matr);