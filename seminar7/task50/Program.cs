// Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

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

void PrintMatrixElement(int[,] matrix, int row, int column)
{
   if (row > 0 || column > 0)
   {
      if (row > matrix.GetLength(0) || column > matrix.GetLength(1))
      {
         System.Console.WriteLine("Элемент в массиве отсутсвует");
      }
      else
      {
         System.Console.WriteLine(matrix[row - 1, column - 1]);
      }
   }
   else
   {
      System.Console.WriteLine("Номер строки и столбца должны быть положительными");
   }

}



int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);
PrintMatrixElement(matr, 1, 6);
PrintMatrixElement(matr, 1, 3);
