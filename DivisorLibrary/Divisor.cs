namespace DivisorLibrary
{
    public class Divisor
    {

        public static DivisorParameter NumberValidator(int enterNumber)
        {
            DivisorParameter parameter = new DivisorParameter();

            parameter.Divisors.Add(enterNumber);
            for (int i = (enterNumber / 2); i >= 1; i--)
            {
                if (enterNumber % i == 0)
                {
                    var result = NumberValidator(i);
                    if (result.Divisors.Count == 2)
                        parameter.Primes.Add(i);

                    parameter.Divisors.Add(i);
                }
            }
            return parameter;
        }
    }
}
