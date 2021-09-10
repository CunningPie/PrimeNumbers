using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static List<int> PrimeNumbers = new List<int>();

        static bool IsPrimeNumber(int N)
        {
            for (int i = 2; i < N; i++)
                if (N % i == 0)
                    return false;
            return true;
        }

        static void AddPrimeNumber(int N)
        {
            if (IsPrimeNumber(N))
                PrimeNumbers.Add(N);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input number: ");
            Double.TryParse(Console.ReadLine(), out double N);

            Parallel.For(2, (int)(N + 1), AddPrimeNumber);
            foreach (int i in PrimeNumbers)
                Console.Write(i + " ");
            Console.ReadKey();
        }
    }
}
