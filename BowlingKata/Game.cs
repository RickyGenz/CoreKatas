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
            int roll = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                ScoreFrame(roll);
                roll += RollModifier(roll);
            }
        }

        private void ScoreFrame(int roll)
        {
            if (IsStrike(roll))
            {
                Points += 10 + StrikeBonus(roll);
            }
            else if (IsSpare(roll))
            {
                Points += 10 + SpareBonus(roll);
            }
            else
            {
                Points += SumPinsInFrame(roll);
            }
        }

        private int RollModifier(int roll)
        {
            return IsStrike(roll) ? 1 : 2;
        }

        private bool IsStrike(int roll)
        {
            return Rolls[roll] == 10;
        }

        private int StrikeBonus(int roll)
        {
            return Rolls[roll + 1] + Rolls[roll + 2];
        }

        private bool IsSpare(int roll)
        {
            return SumPinsInFrame(roll) == 10;
        }

        private int SpareBonus(int roll)
        {
            return Rolls[roll + 2];
        }

        private int SumPinsInFrame(int roll)
        {
            return Rolls[roll] + Rolls[roll + 1];
        }
    }
}
