
using System;
namespace Concession
{
    public class ConcessionCalculator
    {
        private const int TotalFare = 500;//initially giving 500 as price constant
        public static void CalculateConcession(int age, string name)
        {
            if (age <= 5)//for age equals to 5 or less thsn 5
            {
                Console.WriteLine(" According to your age, you are Little Champs !!! You got a free Ticket");
                Console.WriteLine($"Name: {name}, Age: {age}");
            }
            else if (age > 60)
            {
                double discountedFare = TotalFare * 0.3; //  age greater than 60 will have 30% concession
                Console.WriteLine("According to your age, you are Senior Citizen !!! You have a Calculated Fare");
                Console.WriteLine($"Name: {name}, Age: {age}");
                Console.WriteLine($"So your Discounted Fare is : {discountedFare}");
            }
            else
            {
                Console.WriteLine("Your Ticket got Booked");//other ages 
                Console.WriteLine($"Name: {name}, Age: {age}");
                Console.WriteLine($" Your Fare is : {TotalFare}");
            }
        }
    }
}
