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
            Assert.AreEqual(1, PrimeFactors.Count);
            Assert.AreEqual(3, PrimeFactors[0]);
        }

        [TestMethod]
        public void PrimeFactorsOfFour()
        {
            PrimeFactors = PrimeFactorization.Factor(4);
            Assert.AreEqual(2, PrimeFactors.Count);
            Assert.AreEqual(2, PrimeFactors[0]);
            Assert.AreEqual(2, PrimeFactors[1]);
        }

        [TestMethod]
        public void PrimeFactorsOfFive()
        {
            PrimeFactors = PrimeFactorization.Factor(5);
            Assert.AreEqual(1, PrimeFactors.Count);
            Assert.AreEqual(5, PrimeFactors[0]);
        }

        [TestMethod]
        public void PrimeFactorsOfSix()
        {
            PrimeFactors = PrimeFactorization.Factor(6);
            Assert.AreEqual(2, PrimeFactors.Count);
            Assert.AreEqual(2, PrimeFactors[0]);
            Assert.AreEqual(3, PrimeFactors[1]);
        }

        [TestMethod]
        public void PrimeFactorsOfSeven()
        {
            PrimeFactors = PrimeFactorization.Factor(7);
            Assert.AreEqual(1, PrimeFactors.Count);
            Assert.AreEqual(7, PrimeFactors[0]);
        }

        [TestMethod]
        public void PrimeFactorsOfEight()
        {
            PrimeFactors = PrimeFactorization.Factor(8);
            Assert.AreEqual(3, PrimeFactors.Count);
            Assert.AreEqual(2, PrimeFactors[0]);
            Assert.AreEqual(2, PrimeFactors[1]);
            Assert.AreEqual(2, PrimeFactors[2]);
        }
    }
}
