using System;

namespace CampTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) перевірка чи є поле паліндромом
            var vector1 = new Vector(9);
            vector1.InitializationForPalindrome();
            Console.WriteLine(vector1);
            Console.WriteLine(vector1.IsPalindrome());
            Console.WriteLine();

            var vector2 = new Vector(5);
            vector2.RandomInitialization(1, 5);
            Console.WriteLine(vector2);
            Console.WriteLine(vector2.IsPalindrome());
            Console.WriteLine();

            // 2) Reverse
            var vector3 = new Vector(10);
            vector3.ShuffleInitialization();
            Console.WriteLine(vector3);
            vector3.Reverse();
            Console.WriteLine(vector3);
            Console.WriteLine();

            Array array = Array.CreateInstance(typeof(int), 5);
            array.SetValue(1, 0);
            array.SetValue(2, 1);
            array.SetValue(3, 2);
            array.SetValue(4, 3);
            array.SetValue(5, 4);
            PrintArray(array);
            Array.Reverse(array);
            PrintArray(array);
            Console.WriteLine();

            // 3) найдовша послідовність однакових чисел
            Vector vector4 = new Vector(11);
            vector4[0] = 2;
            vector4[1] = 1;
            vector4[2] = 1;
            vector4[3] = 1;
            vector4[4] = 5;
            vector4[5] = 4;
            vector4[6] = 4;
            vector4[7] = 7;
            vector4[8] = 7;
            vector4[9] = 7;
            vector4[10] = 7;
            Console.WriteLine(vector4);
            Console.WriteLine(vector4.FindTheLongestSequence());
            Console.WriteLine();

            // 4) Заповнення діагональною змійкою
            Matrix matrix1 = new Matrix(4, 4);
            matrix1.FillByDiagonalSnake(MatrixTools.Direction.Downward);
            matrix1.PrintMatrix();
            Console.WriteLine();

            Matrix matrix2 = new Matrix(4, 4);
            matrix2.FillByDiagonalSnake(MatrixTools.Direction.Rightward);
            matrix2.PrintMatrix();
            Console.WriteLine();

            // 5) Оптимізований метод InitShuffle
            Vector vector5 = new Vector(15);
            vector5.ShuffleInitialization();
            Console.WriteLine(vector5);


            {
                //Pair pair1 = new Pair(5, 5);
                //Pair pair2 = new Pair(1, 1);
                //Console.WriteLine(pair1.Equals(pair2));

                //var vector = new Vector(5);
                //vector.RandomInitialization(1,5);
                //Console.WriteLine(vector);
                //vector[0] = 111;
                //Console.WriteLine(vector);
                //Pair[] pairs = vector.CalculateFrequency();
                //for (int i = 0; i < pairs.Length; i++)
                //{
                //    Console.WriteLine(pairs[i]);
                //}


                //vector.ShuffleInitialization();
                //Console.WriteLine(vector.ToString());
            }

        }
        public static void PrintArray(Array array)
        {
            for (int i = array.GetLowerBound(0); i <= array.GetUpperBound(0); i++)
            {
                Console.Write(array.GetValue(i) + " ");
            }
            Console.WriteLine();
        }
    }
}
