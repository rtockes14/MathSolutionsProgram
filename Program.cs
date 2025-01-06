using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSolutions
{
    public class Program
    {
        static void Main(string[] args)
        {
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
