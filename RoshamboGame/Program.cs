using RoshamboGame;

bool runAgain = true;

Console.WriteLine("Let's play Rock, Paper, Scissors!");
Console.WriteLine("Please enter your name.");
HumanPlayer humanPlayer = new HumanPlayer();
humanPlayer.Name = Console.ReadLine();

string userSelection = Validator.GetOtherPlayer(humanPlayer);

while (runAgain)
{

    if (userSelection == "Rocco")
    {
        int throwNumber = Validator.GetValidIntegerInputFromUser(humanPlayer);
        Roshambo userThrow = (Roshambo)throwNumber;
        humanPlayer.RoshamboValue = (int)userThrow;

        RockPlayer rockPlayer = new RockPlayer();

        Console.WriteLine($"{humanPlayer.Name}: {userThrow}");
        Console.WriteLine($"Rocco: {rockPlayer.GenerateRoshambo()}");

        if (throwNumber == 1)
        {
            Console.WriteLine("It's a draw!");
        }
        else if (throwNumber == 2)
        {
            Console.WriteLine($"{humanPlayer.Name} wins!");
        }
        else
        {
            Console.WriteLine("Rocco wins!");
        }

    }

    if (userSelection == "Sandy")
    {
        int throwNumber = Validator.GetValidIntegerInputFromUser(humanPlayer);
        Roshambo userThrow = (Roshambo)throwNumber;
        humanPlayer.RoshamboValue = (int)userThrow;

        RandomPlayer randomPlayer = new RandomPlayer();
        string randomThrow = randomPlayer.GenerateRoshambo();

        Console.WriteLine($"{humanPlayer.Name}: {userThrow}");
        Console.WriteLine($"Sandy: {randomThrow}");

        if (throwNumber == 1 && randomThrow == "Rock" || throwNumber == 2 && randomThrow == "Paper" || throwNumber == 3 && randomThrow == "Scissors")
        {
            Console.WriteLine("It's a draw!");
        }
        else if (throwNumber == 1 && randomThrow == "Scissors" || throwNumber == 2 && randomThrow == "Rock" || throwNumber == 3 && randomThrow == "Paper")
        {
            Console.WriteLine($"{humanPlayer.Name} wins!");
        }
        else
        {
            Console.WriteLine("Sandy wins!");
        }

    }

    runAgain = DeterminePlayAgain();
}


bool DeterminePlayAgain()
{
    Console.WriteLine($"{humanPlayer.Name}, would you like to play again?");
    Console.WriteLine($"Press y, to play again. Any other response will end the application.");
    string input = Console.ReadLine().Trim().ToLower();
    return input == "y";
}