using System;
using System.Collections.Generic;

namespace DivisorLibrary
{
    public class DivisorParameter
    {
        public List<int> Divisors { get; set; }

        public List<int> Primes { get; set; }

        public int EnterNumber { get; set; }

        public DivisorParameter()
        {
            Divisors = new List<int>();
            Primes = new List<int>();
        }

        public DivisorParameter(int enterNumber)
        {
            Divisors = new List<int>();
            Primes = new List<int>();
            EnterNumber = enterNumber;
        }
    }
}