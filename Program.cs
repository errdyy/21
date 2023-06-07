using System;

class Program
{
    static void Main()
    {
        int n = 4;
        int m = 5;

        int[,] matrix = new int[n, m];

        FillMatrixSpiral(matrix);

        Console.WriteLine("Заполненная матрица по спирали:");
        PrintMatrix(matrix);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                if (matrix[i, j] == m * n)
                    Console.WriteLine("Начало спирали - элемент [0, 0], конец спирали - элемент [{0}, {1}]", i, j);
        Console.ReadLine();
    }

    static void FillMatrixSpiral(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);

        int currentValue = 1;
        int rowStart = 0, rowEnd = n - 1;
        int colStart = 0, colEnd = m - 1;

        while (currentValue <= n * m)
        {
            for (int i = colStart; i <= colEnd; i++)
            {
                matrix[rowStart, i] = currentValue++;
            }
            rowStart++;

            for (int i = rowStart; i <= rowEnd; i++)
            {
                matrix[i, colEnd] = currentValue++;
            }
            colEnd--;

            for (int i = colEnd; i >= colStart; i--)
            {
                matrix[rowEnd, i] = currentValue++;
            }
            rowEnd--;

            for (int i = rowEnd; i >= rowStart; i--)
            {
                matrix[i, colStart] = currentValue++;
            }
            colStart++;
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}