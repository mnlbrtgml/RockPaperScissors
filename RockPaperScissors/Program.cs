using System;
using System.Linq;

namespace RockPaperScissors
{
    internal class Program
    {
        private static readonly string[] choices = { "rock", "paper", "scissors" };
        private static int computerScore = 0;
        private static int playerScore = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to rock-paper-scissors game\n");

            while (PlayGame()) { }

            DisplayFinalResult();
            Console.ReadKey();
        }

        private static bool PlayGame()
        {
            string computerChoice = GetComputerChoice();
            string playerChoice = GetPlayerChoice();

            if (playerChoice == null)
            {
                Console.WriteLine("\nYou have entered an invalid choice.");
                return AskToPlayAgain();
            }

            UpdateScores(playerChoice, computerChoice);
            DisplayRoundResult(playerChoice, computerChoice);

            return AskToPlayAgain();
        }

        private static string GetComputerChoice()
        {
            Random random = new Random();
            int randomNumber = random.Next(choices.Length);
            return choices[randomNumber];
        }

        private static string GetPlayerChoice()
        {
            Console.Write("Enter your choice (rock, paper, scissors): ");
            string playerChoice = Console.ReadLine();
            return choices.Contains(playerChoice) ? playerChoice : null;
        }

        private static void UpdateScores(string playerChoice, string computerChoice)
        {
            if (playerChoice == computerChoice) return;

            if ((playerChoice == "rock" && computerChoice == "scissors") ||
                (playerChoice == "paper" && computerChoice == "rock") ||
                (playerChoice == "scissors" && computerChoice == "paper"))
            {
                playerScore++;
            }
            else
            {
                computerScore++;
            }
        }

        private static void DisplayRoundResult(string playerChoice, string computerChoice)
        {
            Console.WriteLine($"\nYou have chosen: {playerChoice}");
            Console.WriteLine($"The computer have chosen: {computerChoice}");
            Console.WriteLine($"{GetRoundResultMessage(playerChoice, computerChoice)}\n");
        }

        private static string GetRoundResultMessage(string playerChoice, string computerChoice)
        {
            if (playerChoice == computerChoice) return "It's a tie! No score will be added to anyone.";
            if ((playerChoice == "rock" && computerChoice == "scissors") ||
                (playerChoice == "paper" && computerChoice == "rock") ||
                (playerChoice == "scissors" && computerChoice == "paper"))
            {
                return "You win! 1 point will be added to your score.";
            }
            return "You lose! 1 point will be added to computer's score.";
        }

        private static bool AskToPlayAgain()
        {
            Console.Write("Do you want to play again (y)? ");
            string playAgain = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Welcome to rock-paper-scissors game\n");
            return playAgain == "y";
        }

        private static void DisplayFinalResult()
        {
            string result = playerScore > computerScore ? "You have won this match!" : playerScore < computerScore ? "You have lost this match!" : "You have tied with the computer!";
            
            Console.WriteLine("Thank you for playing rock-paper-scissor game!\n");
            Console.WriteLine($"Your final score is {playerScore}");
            Console.WriteLine($"The computer's final score is {computerScore}");
            Console.WriteLine(result);
        }
    }
}
