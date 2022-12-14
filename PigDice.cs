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
            //System.Console.WriteLine("Game over, you rolled a one");

            return score; 

        }
        public int PlayHighScore(int games) {
            List<int> GameScores = new();
            for(int rounds = 0; rounds < games; rounds++) {
            int score = Play();
            GameScores.Add(score);
            //System.Console.WriteLine($"Game number {rounds+1} resulted in {score}");
            }
            return GameScores.Max();
            }

        

        public int PlayUntilScoreMet(int ScoreReq) {
                int score = 0;
                int highscore = 0;
                ulong games = 0;
                while(score <= ScoreReq) {
                    if(highscore < score) {
                        highscore = score;
                        System.Console.Write($"{highscore}," );
                    }
                    games++;
                    score = Play();
                }
                    System.Console.WriteLine($"\n Congratulations; RNG is on your side.");
                    System.Console.WriteLine($"This only took you {games:N0} games.");
                    return score;
        }
    }
