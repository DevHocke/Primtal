using System;
using System.Collections.Generic;
using System.Linq;

namespace Primtal
{
    class PrimeMethods
    {
        // Declares a list named primeNumbers to store prime numbers.
        private List<long> primeNumbers = new List<long>();
        /// <summary>
        /// Takes a user input and checks if it is a prime number.
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns>True if it is a prime number, False the number is not a prime number.</returns>
        public bool calculateUserInputCheckIfPrimeNumber(long userInput)
        {
            // If user input is less or equal to 1 false is returned.
            if (userInput <= 1)
            {
                return false;
            }
            // Else if userInput is not 2 the for loop starts.
            else if (userInput != 2)
            {
                // To save on calculations square root of user input is used.
                double sqrtUserInput = Math.Sqrt(userInput);
                // The loop starts on 2 and runs the square root of userInput amount of times.
                for (int i = 2; i <= sqrtUserInput; i++)
                {
                    // if userInput modulus i is 0, the number is not a prime number and 
                    // false is returned.
                    if (userInput % i == 0)
                    {
                        return false;
                    }
                }
            }
            // If userInput passes all previous checks it is a prime number and
            // is sent to the method addNextPrimeNumberToPrimeNumberList and true is returned.
            addNextPrimeNumberToPrimeNumberList(userInput);
            return true;
        }
        /// <summary>
        /// Checks after the highest prime number in the list
        /// and then ads the next prime number.
        /// </summary>
        public void CalculateNextPrimeNumber()
        {
            // Checks if the primeNumbers list contains any prime numbers.
            // If it is empty the first prime number 2 is added to the list.
            if (primeNumbers.Count == 0)
            {
                addNextPrimeNumberToPrimeNumberList(2);
            }
            // long n is given the value of the last number in the primeNumber list.
            var n = primeNumbers.Last();
            // For loops that starts with the value of n loops as long as i is less or equal to n+1.
            for (var i = n; i <= n + 1;)
            {
                // Adds 1 to n each loop.
                n++;
                // If the method that calculates prime numbers returns true the loop stops.
                if (calculateUserInputCheckIfPrimeNumber(n))
                {
                    break;
                }
            }
        }
        /// <summary>
        /// Takes a long and checks if it exists in the list of prime numbers.
        /// If it exists, the list of prime numbers is printed to the console.
        /// If it does not exist it is added to the prime number list and the
        /// list is then sorted.
        /// </summary>
        /// <param name="primeNumber"></param>
        public void addNextPrimeNumberToPrimeNumberList(long primeNumber)
        {
            // If the list of prime numbers already contains the number all the stored prime numbers are
            // printed to the console.
            if (primeNumbers.Contains(primeNumber))
            {
                Console.Clear();
                printListOfPrimeNumbers();
            }
            // If the list does not contain the number the number is added to the list and then sorted.
            else
            {
                primeNumbers.Add(primeNumber);
                primeNumbers.Sort();
            }
        }
        /// <summary>
        /// Prints a topic to the console followed by all the
        /// prime numbers that is in the primeNumbers list.
        /// </summary>
        public void printListOfPrimeNumbers()
        {
            // Tells the user that the list is empty if no numbers are stored in the list.
            if (primeNumbers.Count == 0)
            {
                Console.WriteLine("There are no stored prime numbers.");
            }
            else
            {
                Console.WriteLine($"These are the prime numbers in the list:");
                // Prints every number in the primeNumbers list to the console.
                foreach (var number in primeNumbers)
                {
                    Console.WriteLine($"{number}");
                }
            }
        }
    }
}