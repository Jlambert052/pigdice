// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the PigDie Casino; cheat and we feed you to the pig");

//pass in a score, and play the game until you pass that score. Return how many games you play

PigDiceGame.PigDice pigdice = new();

int score = pigdice.PlayHighScore(35);

System.Console.WriteLine($"Highscore is {score}");

//pigdice.PlayUntilScoreMet(100);