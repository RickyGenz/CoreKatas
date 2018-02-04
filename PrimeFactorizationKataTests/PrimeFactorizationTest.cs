using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeFactorizationKata;
using System.Collections.Generic;

namespace PrimeFactorizationKataTests
{
    [TestClass]
    public class PrimeFactorizationTest
    {
        private PrimeFactorization PrimeFactorization;

        private List<int> PrimeFactors;

        [TestInitialize]
        public void InitializePrimeFactorization()
        {
            PrimeFactorization = new PrimeFactorization();
        }

        [TestMethod]
        public void PrimeFactorsOfOne()
        {
            PrimeFactors = PrimeFactorization.Factor(1);
            Assert.AreEqual(0, PrimeFactors.Count);
        }

        [TestMethod]
        public void PrimeFactorsOfTwo()
        {
            PrimeFactors = PrimeFactorization.Factor(2);
            Assert.AreEqual(2, PrimeFactors[0]);
        }

        [TestMethod]
        public void PrimeFactorsOfThree()
        {
            PrimeFactors = PrimeFactorization.Factor(3);
            Assert.AreEqual(3, PrimeFactors[0]);
        }

        [TestMethod]
        public void PrimeFactorsOfFour()
        {
            PrimeFactors = PrimeFactorization.Factor(4);
            Assert.AreEqual(2, PrimeFactors[0]);
            Assert.AreEqual(2, PrimeFactors[1]);
        }
    }
}
