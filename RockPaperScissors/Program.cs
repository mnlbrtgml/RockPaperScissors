using System;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] choices = { "rock", "paper", "scissors" };
            int computerScore = 0;
            int playerScore = 0;
            bool playing = true;

            Console.WriteLine("Welcome to rock-paper-scissors game\n");

            while (playing)
            {
                Random random = new Random();
                int randomNumber = random.Next(choices.Length);
                string computerChoice = choices[randomNumber];
                string remarks;

                Console.Write("Enter your choice (rock, paper, scissors): ");
                string playerChoice = Console.ReadLine();

                switch (playerChoice)
                {
                    case string choice when choice == choices[0]:
                        if (computerChoice == choices[0])
                        {
                            remarks = "Its a tie! No score will be added to anyone.";
                        }
                        else if (computerChoice == choices[1])
                        {
                            remarks = "You lose! 1 point will be added to computer's score.";
                            computerScore++;
                        }
                        else
                        {
                            remarks = "You win! 1 point will be added to your score.";
                            playerScore++;
                        }

                        Console.WriteLine($"\nYou have chosen: {choice}");
                        Console.WriteLine($"The computer have chosen: {computerChoice}");
                        Console.WriteLine($"{remarks}\n");

                        break;

                    case string choice when choice == choices[1]:
                        if (computerChoice == choices[0])
                        {
                            remarks = "You win! 1 point will be added to your score.";
                            playerScore++;
                        }
                        else if (computerChoice == choices[1])
                        {
                            remarks = "Its a tie! No score will be added to anyone.";
                        }
                        else
                        {
                            remarks = "You lose! 1 point will be added to computer's score.";
                            computerScore++;
                        }

                        Console.WriteLine($"\nYou have chosen: {choice}");
                        Console.WriteLine($"The computer have chosen: {computerChoice}");
                        Console.WriteLine($"{remarks}\n");

                        break;

                    case string choice when choice == choices[2]:
                        if (computerChoice == choices[0])
                        {
                            remarks = "You lose! 1 point will be added to computer's score.";
                            computerScore++;

                        }
                        else if (computerChoice == choices[1])
                        {
                            remarks = "You win! 1 point will be added to your score.";
                            playerScore++;
                        }
                        else
                        {
                            remarks = "Its a tie! No score will be added to anyone.";
                        }

                        Console.WriteLine($"\nYou have chosen: {choice}");
                        Console.WriteLine($"The computer have chosen: {computerChoice}");
                        Console.WriteLine($"{remarks}\n");

                        break;

                    default:
                        Console.WriteLine("\nYou have entered an invalid choice.");
                        break;
                }

                Console.Write("Do you want to play again (y)? ");
                string playAgain = Console.ReadLine();
                playing = playAgain == "y";

                Console.Clear();
                Console.WriteLine("Welcome to rock-paper-scissors game\n");
            }

            string result = playerScore > computerScore ? "You have won this match!" : playerScore < computerScore ? "You have lost this match!" : "You have tied with the computer!";

            Console.WriteLine("Thank you for playing rock-paper-scissor game!\n");
            Console.WriteLine($"Your final score is {playerScore}");
            Console.WriteLine($"The computer's final score is {computerScore}");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
