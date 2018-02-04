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

        private void RollSpare()
        {
            Game.Roll(5);
            Game.Roll(5);
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
        public void RollAllOnes()
        {
            RollMany(20, 1);
            Assert.AreEqual(20, Game.Score);
        }

        [TestMethod]
        public void RollOneSpare()
        {
            RollSpare();
            Game.Roll(3);
            RollMany(17, 0);
            Assert.AreEqual(16, Game.Score);
        }

        [TestMethod]
        public void RollOneStrike()
        {
            Game.Roll(10);
            Game.Roll(3);
            Game.Roll(4);
            RollMany(16, 0);
            Assert.AreEqual(24, Game.Score);
        }

        [TestMethod]
        public void PerfectGame()
        {
            RollMany(12, 10);
            Assert.AreEqual(300, Game.Score);
        }
    }
}
