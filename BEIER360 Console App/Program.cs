using System;

namespace BEIER360_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            IFeelGreat classObject = new IFeelGreat(100,65,35);
            User user = classObject.GetUser();

            double PercentageOfFemales = (classObject.GetFemaleUsers() / (double)classObject.GetTotalUsers()) * 100;
            double PercentageOfMales = (classObject.GetMaleUsers() / (double)classObject.GetTotalUsers()) * 100;

            PercentageOfFemales = Math.Round(PercentageOfFemales, 2);
            PercentageOfMales = Math.Round(PercentageOfMales, 2);

            Console.WriteLine("Are you feeling great?");
            string response = Console.ReadLine();

            if (response.Equals("Yes"))
            {
                Console.WriteLine("The User is a Female with 100% certainty");
            } else if (response.Equals("No"))
            {
                Console.WriteLine("\r\n" +"The User could be :" + "\r\n");
                Console.WriteLine("Female - " + PercentageOfFemales + "% probability,");
                Console.WriteLine("Male - " + PercentageOfMales + "% probability.");
                Console.WriteLine("The User is actually a " + user.GetGender());
            }
                

            
        }
    }
}
