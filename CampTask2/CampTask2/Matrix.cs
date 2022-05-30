using System;

namespace CampTask2
{
    class Matrix
    {
        private int n, m;
        private int[,] matrix;

        public Matrix(int n, int m)
        {
            this.n = n; this.m = m;
            matrix = new int[n, m];
        }
        public void FillByDiagonalSnake(MatrixTools.Direction direction)
        {
            if (direction == MatrixTools.Direction.Downward)
            {
                FillByDiagonalSnake1();
            }
            else if (direction == MatrixTools.Direction.Rightward)
            {
                FillByDiagonalSnake2();
            }
            else
            {// де перехоплюється цей виняток?
                throw new Exception("Choose right option!");
            }
        }
        private void FillByDiagonalSnake1()
        {
            if (n != m)
            {
                throw new Exception("Matrix is not square");
            }

            int counter = 1;
            for (int i = 0; i < m; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j <= i; j++)
                        matrix[j, i - j] = counter++;
                }
                else
                {
                    for (int k = i; k >= 0; k--)
                        matrix[k, i - k] = counter++;
                }
            }

            for (int i = m; i <= (m - 1) * 2; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = i - n + 1; j <= this.m - 1; j++)
                        matrix[j, i - j] = counter++;
                }
                else
                {
                    for (int k = this.m - 1; k >= i - n + 1; k--)
                        matrix[k, i - k] = counter++;
                }
            }

        }
        private void FillByDiagonalSnake2()
        {
            if (n != m)
            {
                throw new Exception("Matrix is not square");
            }
            int curr = 1;
            for (int diff = 1 - n; diff <= n - 1; diff++)
            {
                for (int i = 0; i < n; i++)
                {
                    int j = i - diff;

                    if (j < 0 || j >= n)
                        continue;
                    if (((diff + n + 1) & 1) > 0)
                        matrix[i, n - 1 - j] = curr++;
                    else
                        matrix[n - 1 - j, i] = curr++;
                }
            }


        }
        public void PrintMatrix()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine("");
            }
        }
        public void FillBySnake()
        {
            int counter = 1;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < m; j++)
                        matrix[i, j] = counter++;
                }
                else
                {
                    for (int k = m - 1; k >= 0; k--)
                        matrix[i, k] = counter++;
                }
            }
        }
        public void FillBySquare()
        {
            int get = n;
            int middle = get / 2;   
            int stage = 0;
            for (int j = 0; j < middle; j++)
            {
                for (int i = 0; i < middle - stage; i++)
                {
                    matrix[j, i] = 1;
                }
                stage++;
            }

            stage = 0;
            for (int j = middle + 1; j < get; j++)
            {
                for (int i = 0; i <= stage; i++)
                {
                    matrix[j, i] = 2;
                }
                stage++;
            }

            stage = 0;
            for (int j = middle + 1; j < get; j++)
            {
                for (int i = 0; i <= stage; i++)
                {
                    matrix[i, j] = 3;
                }
                stage++;
            }

            stage = 0;
            for (int j = middle + 1; j < get; j++)
            {
                for (int i = n - 1; i >= n - 1 - stage; i--)
                {
                    matrix[j, i] = 4;
                }
                stage++;
            }

        }
    }
}
