using System;
using System.Collections.Generic;


namespace MathSolutions
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<UserModel> users = new List<UserModel>();

            bool stillWorking = true;
            string firstName = MessageHandler.AskUserForName();

            MessageHandler.GreetUser(firstName);

            do
            {
                MessageHandler.DetermineProblem();
                stillWorking = MessageHandler.StillWorking();
            } while (stillWorking);
        }
    }
}
