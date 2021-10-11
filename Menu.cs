using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primtal
{
    class Menu
    {
        /// <summary>
        /// A menu that lets the user make choices to
        /// 1. Check if a number is a prime number.
        /// 2. Print a list of the current stored prime numbers if any.
        /// 3. Add a new highest prime number to the list.
        /// 4. Exit the console program.
        /// Using TryParse the user can not use anything but numbers using the menu or number input.
        /// </summary>
        public void userMenu()
        {
            // Creates an instance of the PrimeMethods class.
            PrimeMethods pm = new PrimeMethods();
            bool keepGoing = true;
            do
            {
                Console.WriteLine("XxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxX");
                Console.WriteLine("x              Prime number calculator                x");
                Console.WriteLine("XxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxX");
                Console.WriteLine("x 1. Check if a number is a Prime number.             x");
                Console.WriteLine("X 2. Print a list of current stored prime numbers.    X");
                Console.WriteLine("x 3. Press to add a new highest prime number to list. x");
                Console.WriteLine("X 4. Exit program.                                    X");
                Console.WriteLine("XxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxX");
                Console.Write("Use menu number: ");
                int.TryParse(Console.ReadLine(), out int menu);
                if (menu == 0 || Math.Sign(menu) == 1)
                {
                    // A Switch case triggering the case matching the users menu choice.
                    // If anything else then a valid input is made case 0 is triggered.
                    switch (menu)
                    {
                        case 1:
                            Console.WriteLine("Enter the number you want to check: ");
                            // If the user input is an allowed number and not negative the bool works is set to true.
                            var works = int.TryParse(Console.ReadLine(), out int numberToCheck);
                            if (works && Math.Sign(numberToCheck) == 1)
                            {   // Checks the approved user input to see if it is a prime number.
                                // If the number is a prime number True will be returned else it will return false.
                                var answer = pm.calculateUserInputCheckIfPrimeNumber(numberToCheck);
                                if (answer)
                                {   
                                    // If answer is true, the answer is printed to the console.
                                    Console.WriteLine("You picked a prime number.");
                                }
                                else
                                {
                                    Console.WriteLine("That is not a prime number.");
                                }
                            }
                            else if (Math.Sign(numberToCheck) == -1)
                            {
                                Console.WriteLine("Do not use negative numbers, please try again: ");
                            }
                            else
                            {
                                Console.WriteLine("Not a valid number, please try again: ");
                            }
                            Console.WriteLine("Press any key to continue. . .");
                            Console.ReadKey(); // Pauses the program until a key is pressed.
                            Console.Clear(); // Clears the console.
                            break;
                        case 2:
                            // Prints the entire list of stored prime numbers in the list if any sorted low -> high.
                            pm.printListOfPrimeNumbers();
                            Console.WriteLine("Press any key to continue. . .");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 3:
                            // Calculates the next number to add based on the current highest value in the list.
                            pm.CalculateNextPrimeNumber();
                            //pm.addNextPrimeNumberToPrimeNumberList(menu);
                            Console.WriteLine("Press any key to continue. . .");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 4:
                            // Exits the program.
                            Console.WriteLine("Exiting the Prime calculator please wait. . .");
                            System.Threading.Thread.Sleep(2750);
                            Environment.Exit(0);
                            break;
                        // Case 0 is the error handling case (if TryParse fails the default is 0).
                        case 0:
                            Console.WriteLine("Not a valid menu choice, please try again: ");
                            // Pauses the thread 1.3 seconds to let the user know that a invalid input was used.
                            System.Threading.Thread.Sleep(1300);
                            Console.Clear();
                            break;
                    }
                }
                else if (Math.Sign(menu) == -1)
                {
                    Console.WriteLine("Do not use negative numbers, please try again: ");
                    System.Threading.Thread.Sleep(1300);
                    Console.Clear();
                }

            } while (keepGoing);
        }
    }
}