using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeFactorizationKata;

namespace PrimeFactorizationKataTests
{
    [TestClass]
    public class PrimeFactorizationTest
    {
        private PrimeFactorization PrimeFactorization;

        private int[] PrimeFactors;

        [TestInitialize]
        public void InitializePrimeFactorization()
        {
            PrimeFactorization = new PrimeFactorization();
        }

        [TestMethod]
        public void PrimeFactorsOfTwo()
        {
            PrimeFactors = PrimeFactorization.Factor(2);
            Assert.AreEqual(PrimeFactors.GetValue(0), 2);
        }
    }
}
