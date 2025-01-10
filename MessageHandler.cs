using System;
using System.Collections.Generic;
using System.Threading;

namespace MathSolutions
{
    public class MessageHandler
    {
        public static UserModel AskUserForName()
        {
            UserModel user = new UserModel();
            string firstName = "";
            bool inputAge = false;
            bool inputZip = false;

            do
            {
                Console.Write(" Please enter your name: \t");
                firstName = Console.ReadLine();

                user.FirstName = firstName;

            } while (string.IsNullOrEmpty(firstName));

            do
            {
                Console.Write(" What is your age?: ");

                try
                {
                    inputAge = int.TryParse(Console.ReadLine(), out int age);
                    user.Age = age;
                }
                catch (Exception e)
                {
                    // Put this in a log somewhere
                    string msg = e.Message;
                    Console.WriteLine("That's not a valid age at all... \n");
                    inputAge = false;
                }
            } while (!inputAge);

            do
            {
                Console.Write(" What is your Zipcode?: ");
                try
                {
                    inputZip = int.TryParse(Console.ReadLine(), out int zipcode);
                    user.Zipcode = zipcode;
                }
                catch (Exception e)
                {
                    string msg = e.Message;
                    Console.WriteLine("Jesus zoomer..   Have you never written a letter before in your life?..  ");
                    inputZip = false;
                }
            } while (!inputZip);

            return user;
        }

        public static void GreetUser(string firstName)
        {
            Console.Clear();
            Console.Write($" Hello {firstName.Substring(0,3) + "man"}        ");
            Thread.Sleep(1500);
            Console.WriteLine("...can I call you that?");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine(" Today we're going to do a bit of number crunching. \n");
            Console.WriteLine("\tThis program can be used to determine all sorts of things");
            Console.WriteLine("\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n\t...But I'm going to need a few details");
        
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
            Console.WriteLine(" First, I'm going to need to know what type of problem we're going to solve. (or type 'exit' to quit)\n");
            Console.WriteLine("\t'A' -- Determine the length of an arc based on the a circle's radius");
            Console.WriteLine("\t'D' -- Some thing I need to implement");
            Console.WriteLine("\t'H' -- Another thing I need to implement\n");

            Console.Write(" Please enter your selection: ");
            string selection = Console.ReadLine();

            switch (selection.ToLower())
            {
                case "exit":
                    return;
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
