using System;

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
                    // If menu choice is above 4 the user is informed that the choice is invalid.
                    if (menu > 4)
                    {
                        InvalidUserChoice();
                    }
                    else
                    {
                        // A Switch case triggering the case matching the users menu choice.
                        // If anything else then a valid input is made case 0 is triggered.
                        switch (menu)
                        {
                            // Case 1 lets the user add a number as input to see if it is a prime number.
                            case 1:
                                CheckPrimeNumber(pm);
                                break;
                            // Case 2 lets the user see a list of currently stored prime numbers.
                            case 2:
                                PrintListOfPrimeNumbers(pm);
                                break;
                            // Case 3 lets the user add a new highest prime number to the list.
                            case 3:
                                AddNextprimeNumberToList(pm);
                                break;
                            // Case 4 is used to exit the program.
                            case 4:
                                ProgramExit();
                                break;
                            // Case 0 is the error handling case (if TryParse fails the default is 0).
                            case 0:
                                InvalidUserChoice();
                                break;
                        }
                    }
                }
                // If the user enters a negative number a text prompting the user to not use negative numbers
                // is printed to the console.
                else if (Math.Sign(menu) == -1)
                {
                    Console.WriteLine("Do not use negative numbers, please try again: ");
                    System.Threading.Thread.Sleep(1300);
                    Console.Clear();
                }
            } while (true); // makes the program run until the user decides to use the exit option in the menu.
        }
        /// <summary>
        /// Method for switch case 0 witch is the default value when using anything but a int
        /// in the menu. Letting the user know that a number needs to be used.
        /// </summary>
        private static void InvalidUserChoice()
        {
            Console.WriteLine("Not a valid menu choice, please try again: ");
            // Pauses the thread 1.3 seconds to let the user know that a invalid input was used.
            System.Threading.Thread.Sleep(1300);
            Console.Clear();
        }
        /// <summary>
        /// Menu choice 4 that lets the user close the program.
        /// </summary>
        private static void ProgramExit()
        {
            Console.WriteLine("Exiting the Prime calculator please wait. . .");
            System.Threading.Thread.Sleep(2750);
            Environment.Exit(0); // Exits the program.
        }
        /// <summary>
        /// Method for menu choice 3 that lets the user add the closest higher prime number to the list.
        /// by pressing key 3 in the menu.
        /// </summary>
        /// <param name="pm"></param>
        private static void AddNextprimeNumberToList(PrimeMethods pm)
        {
            // Calculates the next number to add based on the current highest value in the list.
            pm.CalculateNextPrimeNumber();
            Console.WriteLine("Press any key to continue. . .");
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Method for menu choice 2 that lets the user print the list of current stored prime numbers.
        /// </summary>
        /// <param name="pm"></param>
        private static void PrintListOfPrimeNumbers(PrimeMethods pm)
        {
            // Prints the entire list of stored prime numbers in the list if any sorted low -> high.
            pm.printListOfPrimeNumbers();
            Console.WriteLine("Press any key to continue. . .");
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Method for menu choice 1 that lets the user make a number input to check if
        /// it is a prime number.
        /// </summary>
        /// <param name="pm"></param>
        private static void CheckPrimeNumber(PrimeMethods pm)
        {
            Console.WriteLine("Enter the number you want to check: ");
            // If the user input is an allowed number and not negative the bool works is set to true.
            var works = int.TryParse(Console.ReadLine(), out int numberToCheck);
            if (works && Math.Sign(numberToCheck) == 1)
            {
                // Checks the approved user input to see if it is a prime number.
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
        }
    }
}