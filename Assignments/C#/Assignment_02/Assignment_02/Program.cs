using System;

namespace Assignment_02
{
    class Average

    {
        public static void Main()

        {

            int[] arr = { 8, 6, 10, 21, 18 };
            int i = 0;
            int sum = 0;
            float average = 0.0F;
            for (i = 0; i < arr.Length; i++)
            {

                sum += arr[i];

            }
            average = (float)sum / arr.Length;
            Console.WriteLine("Average of Array elements: " + average);
            Console.Read();
        }
    }
}
