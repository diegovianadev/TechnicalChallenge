using System.Collections.Generic;

namespace DivisorLibrary
{
    public class DivisorParameter
    {
        public List<int> Divisors { get; set; }

        public List<int> Primes { get; set; }

        public DivisorParameter()
        {
            this.Divisors = new List<int>();
            this.Primes = new List<int>();
        }
    }
}