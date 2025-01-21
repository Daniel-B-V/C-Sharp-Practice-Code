
class Program
{
    static void Main()
    {
    Random random = new Random();

     bool playAgain = true;
     int max = 101;
     int min = 1;
     int guesses;
     int guess;
     int number;
     string answer = "";

    while(playAgain){
        guesses = 0;
        guess = 0;
        number = random.Next(min, max);
        Console.WriteLine("Guess a number between (1- 100)");

        while(guess != number){
            Console.Write("Guess: ");
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess < number){
                Console.WriteLine("Guess is too low!");
            }
            else if (guess > number){
                Console.WriteLine("Guess is too high!");
            }
            guesses++; 
        }
        Console.WriteLine("Congrats you guess the right number!");
        Console.WriteLine("Number of guesses: " + guesses);
        Console.Write("Do you want to play again? (Y/N): ");
        answer = Console.ReadLine();
        answer = answer.ToUpper();

        if (answer == "Y"){
            playAgain = true;
        }

        else{
            playAgain = false;
        }
    }
        Console.WriteLine("Thanks for playing!");
    }
}
