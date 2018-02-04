using System.Collections.Generic;

namespace PrimeFactorizationKata
{
    public class PrimeFactorization
    {
        public List<int> Factor(int number)
        {
            List<int> PrimeFactors = new List<int>();
            int PotentialFactor = 2;
            while (number > 1)
            {
                while (number % PotentialFactor == 0)
                {
                    PrimeFactors.Add(PotentialFactor);
                    number /= PotentialFactor;
                }
                PotentialFactor++;
            }
            return PrimeFactors;
        }
    }
}
