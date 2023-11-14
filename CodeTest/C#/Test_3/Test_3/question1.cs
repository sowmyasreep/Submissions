using System;
namespace Test_3
{
    class Cricket
    {
        public void PointsCalculation(int no_of_matches)
        {
            int sum = 0;
            for (int i = 1; i <= no_of_matches; i++)
            {
                Console.Write($"Please enter the score for match {i}: ");
                int score = Convert.ToInt32(Console.ReadLine());
                sum += score;
            }
            double average = (double)sum / no_of_matches;
            Console.WriteLine($"Sum of scores are : {sum}");
            Console.WriteLine($"Average score is : {average:F2}");
        }
    }
    class question1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to IPL  cricket teams");
            Console.Write("Enter the number of matches: ");
            int no_of_matches = Convert.ToInt32(Console.ReadLine());
            Cricket cric = new Cricket();
            cric.PointsCalculation(no_of_matches);
        }
    }
}