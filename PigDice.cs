namespace PigDiceGame;

    public class PigDice {

            Random random = new();
        private int RollDie() {
           return random.Next(1, 7);
           
        }
        public int Play() {
            int score = 0;
            int roll = RollDie();
            while ((roll = RollDie()) != 1) {
                score +=roll;
                //roll = RollDie();
            }
            System.Console.WriteLine("Game over, you rolled a one");

            return score; 

        }
        public int PlayHighScore(int games) {
            List<int> GameScores = new();
            for(int rounds = 0; rounds < games; rounds++) {
            int score = Play();
            GameScores.Add(score);
            System.Console.WriteLine($"Game number {rounds+1} resulted in {score}");
            }
            return GameScores.Max();
            }

        

        public int PlayUntilScoreMet(int ScoreReq) {
                int score = 0;
                int games = 0;
                while(score <= ScoreReq) {
                    games++;
                    score = Play();
                }
                    System.Console.WriteLine("Congratulations; RNG is on your side.");
                    System.Console.WriteLine($"This only took you {games} games.");
                    return score;
        }
    }
