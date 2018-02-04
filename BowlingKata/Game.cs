namespace BowlingKata
{
    public class Game
    {
        private int Points;
        private int CurrentRoll;
        private int[] Rolls = new int[21];

        public int Score
        {
            get
            {
                ScoreFrames();
                return Points;
            }
        }

        public void Roll(int pins)
        {
            Rolls[CurrentRoll++] = pins;
        }

        private void ScoreFrames()
        {
            int currentRoll = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (Rolls[currentRoll] == 10)
                {
                    Points += 10 + Rolls[currentRoll + 1] + Rolls[currentRoll + 2];
                    currentRoll += 1;
                }
                else if (Rolls[roll] + Rolls[roll + 1] == 10)
                {
                    Points += 10 + Rolls[roll + 2];
                    roll += 2;
                }
                else
                {
                    Points += Rolls[roll] + Rolls[roll + 1];
                    roll += 2;
                }
            }
        }

        private bool IsStrike(int roll)
        {
            return Rolls[roll] == 10;
        }

        private int StrikeBonus(int roll)
        {
            return Rolls[roll + 1] + Rolls[roll + 2];
        }
    }
}
