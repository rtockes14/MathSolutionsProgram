using System;
using System.Collections.Generic;
using System.Threading;

namespace MathSolutions
{
    public class MessageHandler
    {
        public static string AskUserForName()
        {
            List<UserModel> users = new List<UserModel>();
            string firstName = "";

            do
            {
                Console.Write("Please enter your name (or type exit to stop): \t");
                firstName = Console.ReadLine();

                if (firstName.ToLower() != "exit")
                {
                    UserModel user = new UserModel();
                    user.FirstName = firstName;
                    users.Add(user);
                }

            } while (firstName != "exit");

            //foreach (UserModel u in users)
            //{
            //    Console.WriteLine(u.FirstName);
            //}

            Console.ReadLine();
            return firstName;
        }

        public static void GreetUser(string firstName)
        {
            Console.Clear();
            Console.WriteLine($"Hello {firstName}, today we're going to do a bit of number crunching. \n");
            Console.WriteLine("This program can be used to determine all sorts of things...");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n...But I'm going to need a few details");
            Thread.Sleep(5000);
        }
        public static (double x, double y) GatherDoubles(string firstMessage, string secondMessage)
        {
            bool isValid;
            double x, y;

            do
            {
                Console.Clear();
                Console.Write(firstMessage);

                isValid = double.TryParse(Console.ReadLine(), out x);
            }
            while (!isValid);
            isValid = false;
            do
            {
                Console.Clear();
                Console.Write(secondMessage);
                isValid = double.TryParse(Console.ReadLine(), out y);
            }
            while (!isValid);

            return (x, y);
        }

        public static void PrintAnswer(string answer)
        {
            Console.Clear();
            Console.WriteLine(answer);
            Thread.Sleep(2000);
        }

        public static void DetermineProblem()
        {
            Console.Clear();
            Console.WriteLine("First, I'm going to need to know what type of problem we're going to solve. \n");
            Console.WriteLine("\t'A' -- Determine the length of an arc based on the a circle's radius");
            Console.WriteLine("\t'D' -- Some thing I need to implement");
            Console.WriteLine("\t'H' -- Another thing I need to implement\n");

            Console.Write("Please enter your selection: ");
            string selection = Console.ReadLine();

            switch (selection.ToLower())
            {
                case "a":
                    DifferentCalculations.DistanceGivenAngle();
                    break;
                case "d":
                    DifferentCalculations.ConvertToRadian();
                    break;
                case "h":
                    DifferentCalculations.SomethingElse();
                    break;
                default:
                    Console.WriteLine("That was an invalid selection..  c'mon try again\n");
                    break;

            }
        }

        public static bool StillWorking()
        {
            bool stillAsking;
            Console.Write("Did you have anything else you wanted to solve for? (yes/no): ");
            string response = Console.ReadLine();

            if (response.ToLower() == "yes" || response.ToLower() == "y")
            {
                stillAsking = true;
            }
            else
            {
                stillAsking = false;
            }
            return stillAsking;
        }
    }
}
