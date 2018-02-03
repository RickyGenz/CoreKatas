using BowlingKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingKataTests
{
    [TestClass]
    class GameTest
    {
        [TestInitialize]
        void InitializeGame()
        {
            Game Game = new Game();
        }
    }
}
