using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class PrimeCounter
    {
        private readonly List<long> _primes = new List<long>();

        public PrimeCounter(int count)
        {
            if(count < 1)
                return;

            CountPrimes(count - 1);
            _primes.Insert(0, 2);
        }

        private void CountPrimes(int count)
        {
            var candidate = 1L;
            while(count > 0)
            {
                candidate += 2;
                var sqr = Math.Sqrt(candidate);
                var isPrime = true;
                foreach(var knownPrime in _primes)
                {
                    if(sqr < knownPrime)
                        break;

                    if(candidate % knownPrime == 0L)
                    {
                        isPrime = false;
                        break; 
                    } 
                }

                if(isPrime)
                {
                    _primes.Add(candidate);
                    count--;
                }
            }
        }

        public bool IsPrime(long n) => _primes.Contains(n);

        public long LargestPrime => _primes.Last();
    }
}
