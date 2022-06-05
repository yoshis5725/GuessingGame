using System;

namespace GuessingGame
{
    class Program
    {

        public static void CheckUserGuess(int computerNumber)
        {
            while(true)
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                int userInput = int.Parse(Console.ReadLine());

                if (userInput > computerNumber)
                {
                    Console.WriteLine("Your guess is too high!");
                    //return;

                }
                else if (userInput < computerNumber)
                {
                    Console.WriteLine("Your guess is too low!");
                    //return;

                }
                else
                {
                    Console.WriteLine("Nevermind");
                    break;
                }

            }

        }


        public static void UserSubjectCase(string userAnswer)
        {
            switch(userAnswer)
            {
                case "math":
                    Console.WriteLine("Math - You will be taking Algebra 3 this semester");
                    break;
                case "science":
                    Console.WriteLine("Science - You will be taking Biology 2 this semester");
                    break;
                case "history":
                    Console.WriteLine("History - You will be taking World History 1887 - Present this semester");
                    break;
                case "shop":
                    Console.WriteLine("Shop - You will be building a wall with brick and mortar");
                    break;
                case "computer science":
                    Console.WriteLine("Computer Science - You will be taking C# this semester");
                    break;
                default:
                    Console.WriteLine("That class is not offered this semester");
                    break;
            }
        }


        static void Main(string[] args)
        {
            Random r = new Random();
            int computerGeneratedNumber = r.Next(1, 10);
            Console.WriteLine($"random number ---> {computerGeneratedNumber}");
            CheckUserGuess(computerGeneratedNumber);

            Console.WriteLine("------ Exercise 2 ------");
            Console.WriteLine("What is your favorite school subject? ");
            string userFavoriteSubject = Console.ReadLine();
            UserSubjectCase(userFavoriteSubject);
        }
    }
}

