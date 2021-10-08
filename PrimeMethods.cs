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
            // loopa samtliga tal mellan 0 och userinput
            Math.Sqrt(userInput);
            return true;
        }

        public void addNextPrimeNumberToPrimeNumberList()
        {

        }

        public void printListOfPrimeNumbers()
        {
            foreach (var number in primeNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}