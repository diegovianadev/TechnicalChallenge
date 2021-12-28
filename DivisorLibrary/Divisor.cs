namespace DivisorLibrary
{
    public class Divisor
    {

        public static DivisorParameter GetPrimesAndDivisorsNumbers(DivisorParameter parameter)
        {
            DivisorParameter newParameter = parameter;

            if (parameter.EnterNumber >= 1)
            {
                for (int i = 1; i <= (parameter.EnterNumber / 2); i++)
                {
                    if (parameter.EnterNumber % i == 0)
                    {
                        var result = GetPrimesAndDivisorsNumbers(new DivisorParameter(i));
                        if (result.Divisors.Count == 2)
                            newParameter.Primes.Add(i);

                        newParameter.Divisors.Add(i);
                    }
                }
                newParameter.Divisors.Add(parameter.EnterNumber);

                if (newParameter.Divisors.Count == 2)
                    newParameter.Primes.Add(parameter.EnterNumber);
            }
            
            return newParameter;
        }
    }
}

