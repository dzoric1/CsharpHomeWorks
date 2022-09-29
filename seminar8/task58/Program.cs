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

int[,] MatrixMulti(int[,] matrix, int[,] matrix2)
{
   int[,] resultMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         resultMatrix[i, j] = matrix[i, j] * matrix2[i, j];
      }
   }
   return resultMatrix;
}

int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
int[,] matr = GetMatrix(m, n, 0, 10);
int[,] matr2 = GetMatrix(m, n, 0, 10);
PrintMatrix(matr);
System.Console.WriteLine();
PrintMatrix(matr2);
System.Console.WriteLine();
PrintMatrix(MatrixMulti(matr, matr2));