int[,,] array3D = new int[2, 2, 2] { { { 1, 2}, { 4, 5} },
                                    { { 7, 8,}, { 10, 11} } };

void PrintMatrix(int[,,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      System.Console.WriteLine($"Глубина: {i + 1}");
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         for (int k = 0; k < matrix.GetLength(1); k++)
         {
            Console.Write($"{matrix[i, j, k]}:({i},{j},{k})  ");
         }
         Console.WriteLine();
      }
   }
}

PrintMatrix(array3D);