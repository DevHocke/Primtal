using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Primtal
{
    class PrimeMethods
    {
        // Declares a list named primeNumbers to store prime numbers.
        private List<int> primeNumbers = new List<int>();
        /// <summary>
        /// Takes a user input and checks if it is a prime number.
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns>True if it is a prime number, False the number is not a prime number.</returns>
        public bool calculateUserInputCheckIfPrimeNumber(int userInput)
        {
            // If userinput is less or equal to 1 false is returned.
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

        public void CalculateNextPrimeNumber()
        {
            // Checks if the primeNumbers list cotains any prime numbers.
            // If it is empty the first prime number 2 is added to the list.
            if (primeNumbers.Count == 0)
            {
                addNextPrimeNumberToPrimeNumberList(2);
            }
            // int n is given the value of the last number in the primeNumber list
            // The list is sorted lowest to highest value, therefor the last value is the highest
            // number in the primeNumber list.
            int n = primeNumbers.Last();
            // Takes the square root of n (highest value in the list) and stores it in 
            // a new int to make the calculations needed much more time effective.
            int sqrtNextNumber = (int)Math.Sqrt(n);

            

        }
        /// <summary>
        /// Takes a int and checks if it exists in the list of prime numbers.
        /// If it exists, the list of prime numbers is printed to the console.
        /// If it does not exist it is added to the prime number list and the
        /// list is then sorted.
        /// </summary>
        /// <param name="primeNumber"></param>
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
        /// <summary>
        /// Prints a topic to the console followed by all the
        /// prime numbers that is in the primeNumbers list.
        /// </summary>
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