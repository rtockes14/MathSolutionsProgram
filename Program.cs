using System;
using System.Collections.Generic;


namespace MathSolutions
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool stillWorking = true;
            UserModel user = MessageHandler.AskUserForName();

            MessageHandler.GreetUser(user.FirstName);

            do
            {
                MessageHandler.DetermineProblem();
                stillWorking = MessageHandler.StillWorking();
            } while (stillWorking);
        }
    }
}
