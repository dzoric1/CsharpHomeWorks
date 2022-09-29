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

int[,] SortingMatrix(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         for (int k = 0; k < matrix.GetLength(1) - 1; k++)
         {
            if (matrix[i, k] > matrix[i, k + 1])
            {
               int temp = matrix[i, k];
               matrix[i, k] = matrix[i, k + 1];
               matrix[i, k + 1] = temp;
            }
         }
      }
   }
   return matrix;
}

int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);
SortingMatrix(matr);
System.Console.WriteLine();
PrintMatrix(matr);