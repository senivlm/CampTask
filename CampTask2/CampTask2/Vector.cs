using System;

namespace CampTask2
{
    class Vector
    {
        private int[] array;

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                {
                    return array[index];
                }
                else
                {
                    throw new Exception("Array index out of range");
                }
            }
            set
            {
                array[index] = value;
            }
        }
        public Vector(int n)
        {
            array = new int[n];
        }
        public void RandomInitialization(int a, int b)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(a, b);
            }
        }

        //public void ShuffleInitialization() \\ метод з лекції
        //{
        //    int r;
        //    Random rnd = new Random();
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        while (true)
        //        {
        //            r = rnd.Next(1, array.Length + 1);
        //            bool isExist = false;
        //            for (int j = 0; j < i; j++)
        //            {
        //                if (array[j] == r)
        //                {
        //                    isExist = true;
        //                    break;
        //                }
        //            }
        //            if (!isExist)
        //            {
        //                array[i] = r;
        //                break;
        //            }
        //        }
        //    }
        //} 

        public void ShuffleInitialization()
        {
            Random random = new Random();
            int arrayLength = array.Length;
            int r;
            for (int i = 1; i < arrayLength + 1; i++)
            {
                r = random.Next(0, arrayLength);
                if (array[r] == 0)
                {
                    array[r] = i;
                }
                else
                {//Незрозуміла логіка
                    for (int j = r + 1; j < r + arrayLength; j++)
                    {
                        if (array[j % arrayLength] == 0)
                        {
                            array[j % arrayLength] = i;
                            break;
                        }
                    }

                }
            }

        }
        public void InitializationForPalindrome()
        {
            array = new int[9] { 1, 2, 3, 4, 5, 4, 3, 2, 1 };
        }
        public Pair[] CalculateFrequency()
        {
            Pair[] pairs = new Pair[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                pairs[i] = new Pair(0, 0);
            }
            int countOfDiffer = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool isElement = false;
                for (int j = 0; j < countOfDiffer; j++)
                {
                    if (array[i] == pairs[j].Number)
                    {
                        pairs[j].Frequency++;
                        isElement = true;
                        break;
                    }
                }
                if (!isElement)
                {
                    pairs[countOfDiffer].Frequency++;
                    pairs[countOfDiffer].Number = array[i];
                    countOfDiffer++;

                }
            }
            Pair[] result = new Pair[countOfDiffer];
            for (int i = 0; i < countOfDiffer; i++)
            {
                result[i] = pairs[i];
            }
            return result;
        }
        public override string ToString()
        {
            string output = "";
            for (int i = 0; i < array.Length; i++)
            {
                output += array[i] + " ";
            }
            return output;
        }
        public bool IsPalindrome()
        {// тут достатньо одного індекса, який рухається до половини масиву.
            for (int firstElem = 0, lastElem = array.Length - 1; firstElem < lastElem; firstElem++, lastElem--)
            {
                if (array[firstElem] != array[lastElem])
                {
                    return false;
                }

            }
            return true;
        }
        public void Reverse()
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }
        }
        public string FindTheLongestSequence()
        {
            int theLongestElem, counter, mainCounter = 0;
            string result = "";

            for (int i = 0; i < array.Length - 1; i++)
            {
                counter = 1;
                theLongestElem = 0;
                while (array[i] == array[i + 1])
                {
                    theLongestElem = array[i];
                    counter++;
                    i++;
                    if (i == array.Length - 1)
                    {
                        break;
                    }
                }

                if (mainCounter < counter)
                {
                    mainCounter = counter;
                    result = "";
                    for (int elem = 0; elem < mainCounter; elem++)
                    {
                        result += theLongestElem + " ";
                    }
                }
            }
            return result;
        }


    }
}
