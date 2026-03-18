using System.Numerics;

namespace Blazor.Components.Pages
{
    public partial class Fibonacci
    {
        long number = 10;
        BigInteger fibonacci = 55;
        List<BigInteger> results = new();//оказывается можно и так и new List<BigInteger>()

        void OnNumberChanged()
        {
            Calculate();
        }

        void Calculate()
        {
            results.Clear();

            BigInteger a = 0;
            BigInteger b = 1;

            for (int i = 0; i <= number; i++)
            {
                results.Add(a);
                BigInteger temp = a + b;
                a = b;
                b = temp;
            }

            fibonacci = results[^1];
        }
    }
}
