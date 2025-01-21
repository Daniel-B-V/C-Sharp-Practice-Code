
namespace Program;
class HandGame
{
    static void Main()
    {
        Random random = new Random();
        bool playAgain = true;
        string player;
        string computer;
        string answer;
   
        while (playAgain)
        {
            Console.WriteLine("Choose Rock, Paper, or Scissors:");
            player = Console.ReadLine()?.ToLower(); // Convert to lowercase for consistency

            // Validate player input
            if (player != "rock" && player != "paper" && player != "scissors")
            {
                Console.WriteLine("Invalid choice. Please choose Rock, Paper, or Scissors.");
                continue;
            }
          
            int computerChoice = random.Next(1, 4);
            computer = computerChoice switch
            {
                1 => "rock",
                2 => "paper",
                3 => "scissors",
                _ => "rock" // Default case 
            };

            Console.WriteLine($"Player: {player}");
            Console.WriteLine($"Computer: {computer}");

            if (player == computer)
            {
                Console.WriteLine("It's a draw!");
            }
            else if ((player == "rock" && computer == "scissors") ||
                     (player == "scissors" && computer == "paper") ||
                     (player == "paper" && computer == "rock"))
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }

            Console.WriteLine("Do you want to play again? (Y/N):");
            answer = Console.ReadLine()?.ToUpper();

            playAgain = (answer == "Y");
        }

        Console.WriteLine("Thanks for playing!");
    }
}
