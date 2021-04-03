using System;

namespace BEIER360_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            IFeelGreat classObject = new IFeelGreat(100,65,35);//and instance of 100 total users, 65 males and 35 females
            User user = classObject.GetUser();//get a user with a random id number(50) and a random gender (Male/Female)

            double PercentageOfFemales = (classObject.GetFemaleUsers() / (double)classObject.GetTotalUsers()) * 100;//working out percentage of females in total user population
            double PercentageOfMales = (classObject.GetMaleUsers() / (double)classObject.GetTotalUsers()) * 100;

            PercentageOfFemales = Math.Round(PercentageOfFemales, 2);
            PercentageOfMales = Math.Round(PercentageOfMales, 2);

            Console.WriteLine("Are you feeling great?");
            string response = Console.ReadLine();

            if (response.Equals("Yes") || response.Equals("yes") || response.Equals("y"))
            {
                Console.WriteLine("The User is a Female with 100% certainty");
            } else if (response.Equals("No") || response.Equals("no") || response.Equals("n"))
            {
                Console.WriteLine("\r\n" +"The User could be :" + "\r\n");
                Console.WriteLine("Female - " + PercentageOfFemales + "% probability,");
                Console.WriteLine("Male - " + PercentageOfMales + "% probability.");
                Console.WriteLine("The User is actually a " + user.GetGender());
            }
                
        }
    }
}
