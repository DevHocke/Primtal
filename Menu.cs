using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primtal
{
    class Menu
    {
        public void userMenu()
        {
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
                Console.WriteLine("X 0. Exit program.                                    X");
                Console.WriteLine("XxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxXxX");
                Console.Write("Use menu number: ");
                var works = int.TryParse(Console.ReadLine(), out int menu);

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Enter the number you want to check: ");
                        
                            works = int.TryParse(Console.ReadLine(), out int numberToCheck);
                            if (works)
                            {
                                pm.calculateUserInputCheckIfPrimeNumber(numberToCheck);
                            }
                            else
                            {
                                 Console.WriteLine("Not a valid menu number, please try again: ");
                            }
                            Console.WriteLine("Press any key to continue. . .");
                            Console.ReadKey();
                            Console.Clear();
                        break;
                    case 2:
                        new PrimeMethods().printListOfPrimeNumbers();
                        Console.WriteLine("Press any key to continue. . .");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        new PrimeMethods().addNextPrimeNumberToPrimeNumberList();
                        Console.WriteLine("Press any key to continue. . .");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Exiting the Prime calculator please wait. . .");
                        System.Threading.Thread.Sleep(2750);
                        Environment.Exit(0);
                        break;
                    case 0:
                        Console.WriteLine("Not a valid menu choice, please try again: ");
                        System.Threading.Thread.Sleep(1300);
                        Console.Clear();
                        break;
                }

            } while (keepGoing);
        }
    }
}