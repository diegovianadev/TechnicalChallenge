using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DivisorLibrary
{
    public class DivisorParameter
    {
        public List<int> Divisors { get; private set; }

        public List<int> Primes { get; private set; }

        [Required]
        [Range(1,int.MaxValue, ErrorMessage = "O valor precisa ser um número e maior que um.")]
        public int EnterNumber { get; set; }

        public DivisorParameter()
        {
            Divisors = new List<int>();
            Primes = new List<int>();
        }

        public DivisorParameter(int enterNumber)
        {
            EnterNumber = enterNumber;
            Divisors = new List<int>();
            Primes = new List<int>();
        }

        public DivisorParameter(int enterNumber, List<int> divisors, List<int> primes)
        {
            EnterNumber = enterNumber;
            Divisors = divisors;
            Primes = primes;
        }
    }
}