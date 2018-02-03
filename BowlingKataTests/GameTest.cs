using BowlingKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingKataTests
{
    [TestClass]
    public class GameTest
    {
        private Game Game;

        private void RollMany(int rolls, int pins)
        {
            for (int roll = 0; roll < rolls; roll++)
            {
                Game.Roll(pins);
            }
        }

        [TestInitialize]
        public void InitializeGame()
        {
            Game = new Game();
        }

        [TestMethod]
        public void GutterGame()
        {
            RollMany(20, 0);
            Assert.AreEqual(0, Game.Score);
        }

        [TestMethod]
        public void AllOnesGame()
        {
            RollMany(20, 1);
            Assert.AreEqual(20, Game.Score);
        }
    }
}
