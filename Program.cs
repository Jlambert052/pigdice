// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the PigDie Casino; cheat and we feed you to the pig");
PigDiceGame.PigDice pigdice = new();

int ScoreOrGames = int.Parse(args[1]);

if(args[0] == "--games") {
    var highscore = pigdice.PlayHighScore(ScoreOrGames);
    System.Console.WriteLine($"After {ScoreOrGames} games, the high score is {highscore}");
} else {
   var games = pigdice.PlayUntilScoreMet(ScoreOrGames);
   System.Console.WriteLine($"\n{ScoreOrGames} took {games:N0} of games");
}


System.Threading.Thread.Sleep(5000);