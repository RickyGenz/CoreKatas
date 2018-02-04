using System.Collections.Generic;

namespace PrimeFactorizationKata
{
    public class PrimeFactorization
    {
        public List<int> Factor(int number)
        {
            List<int> PrimeFactors = new List<int>();
            while (number > 1)
            {
                if (number % 2 == 0)
                {
                    PrimeFactors.Add(2);
                    number = number / 2;
                }
                else
                {
                    PrimeFactors.Add(number);
                    number = number / number;
                }
            }
            return PrimeFactors;
        }
    }
}
