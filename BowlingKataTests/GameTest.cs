using BowlingKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingKataTests
{
    [TestClass]
    public class GameTest
    {
        Game Game;

        [TestInitialize]
        public void InitializeGame()
        {
            Game = new Game();
        }

        [TestMethod]
        public void GutterGame()
        {
            for (int i = 0; i < 20; i++)
            {
                Game.Roll(0);
            }
            Assert.AreEqual(0, Game.Score);
        }
    }
}
