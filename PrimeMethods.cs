using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primtal
{
    class PrimeMethods
    {
        private List<int> primeNumbers = new List<int>();

        public bool calculateUserInputCheckIfPrimeNumber(int userInput)
        {
            // ger roten ur talet.
            // loopa samtliga tal mellan 0 och roten ur userinput
            double sqrtUserInput = Math.Sqrt(userInput);
            double answer;
            for (int i = 1; i <= Math.Floor(sqrtUserInput); i++)
            {
                
            }
            return false;
        }

        public void addNextPrimeNumberToPrimeNumberList(int primeNumber)
        {
            if (primeNumbers.Contains(primeNumber))
            {
                printListOfPrimeNumbers();
            }
            else
            {
                primeNumbers.Add(primeNumber);
                primeNumbers.Sort();
            }
        }

        public void printListOfPrimeNumbers()
        {
            Console.WriteLine($"These are the prime numbers in the list:");
            foreach (var number in primeNumbers)
            {
                Console.WriteLine($"{number}");
            }
        }
    }
}