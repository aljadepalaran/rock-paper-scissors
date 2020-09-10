using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scissors
{
    class Program
    {

        public static int userScore;

        static void Main(string[] args)
        {

            userScore = 0;

            Console.WriteLine("Welcome to Rock Paper Scissors");

            UserPick();

            // add score indicator
            // add input validation for choices outside 1,2,3
            // indent outputs
            // change input to string
            // find better way to compare

            Console.ReadLine();

        }

        public static void UserPick()
        {

            int choice;

            Console.WriteLine("1. Rock" +
                   "2. Paper" +
                   "3. Scissors");

            Console.Write("Please enter your choice (1/2/3): ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Compare("rock");
                    break;
                case 2:
                    Compare("paper");
                    break;
                case 3:
                    Compare("scissor");
                    break;
                default:
                    break;

            }

        }

        public static void ChangeScore(int result)
        {

            switch (result)
            {
                case 0:
                    Console.WriteLine("DRAW: Score Unchanged.");
                    UserPick();
                    break;
                case 1:
                    Console.WriteLine("WIN: Score + 1");
                    userScore += 1;
                    UserPick();
                    break;
                case 2:
                    Console.WriteLine("LOSS: Score -1");
                    userScore -= 1;
                    UserPick();
                    break;
                default:
                    break;
            }

        }

        public static int Compare(string choice)
        {

            string machineChoice = GenerateChoice();

            if (choice == "rock")
            {
                if (machineChoice == "rock")
                {
                    ChangeScore(0); // draw
                }
                else if (machineChoice == "paper")
                {
                    ChangeScore(2); // user lose
                }
                else if (machineChoice == "scissor")
                {
                    ChangeScore(1); // user win
                }
            }
            else if (choice == "paper")
            {
                if (machineChoice == "rock")
                {
                    ChangeScore(1); // user win
                }
                else if (machineChoice == "paper")
                {
                    ChangeScore(0); // draw
                }
                else if (machineChoice == "scissor")
                {
                    ChangeScore(2); // user lose
                }
            }
            else if (choice == "scissor")
            {
                if (machineChoice == "rock")
                {
                    ChangeScore(2); // user lose
                }
                else if (machineChoice == "paper")
                {
                    ChangeScore(1); // user win
                }
                else if (machineChoice == "scissor")
                {
                    ChangeScore(0); // draw
                }
            }

            return 0; // 0 = draw, 1 = win, 2 = loss
 
        }

        public static string GenerateChoice()
        {

            Random generator = new Random();

            int rndchoice = generator.Next(0, 3);

            switch (rndchoice)
            {
                case 0:
                    Console.WriteLine("BOT: Rock");
                    return "rock";
                case 1:
                    Console.WriteLine("BOT: Paper");
                    return "paper";
                case 2:
                    Console.WriteLine("BOT: Scissor");
                    return "scissor";
            }

            return null;

        }
    }
}
