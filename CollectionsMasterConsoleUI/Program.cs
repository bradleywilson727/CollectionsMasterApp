using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50 DONE

            var nameOfArray = new int[50];


            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50 DONE

            Populater(nameOfArray);


            //TODO: Print the first number of the array DONE

            Console.WriteLine(nameOfArray[0]);

            //TODO: Print the last number of the array DONE

            Console.WriteLine(nameOfArray[49]);
            //$"{nameOfArray[nameOfArray.Length - 1]} will do the same thing if you don't know the length of your array

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists DONE

            NumberPrinter(nameOfArray);

            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); DONE
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇) DONE
            */

            Console.WriteLine("All Numbers Reversed:");

            //L
            //var numbersReversed = nameOfArray.Reverse();
            //NumberPrinter(numbersReversed);

            Array.Reverse(nameOfArray);

            NumberPrinter(nameOfArray);

            Console.WriteLine("---------REVERSE CUSTOM------------");

            ReverseArray(nameOfArray);
            Console.WriteLine(nameOfArray);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            ThreeKiller(nameOfArray);
            NumberPrinter(nameOfArray);
            

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now DONE
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");


            Array.Sort(nameOfArray);

            NumberPrinter(nameOfArray);
            

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List DONE

            var customNumberList = new List<int>();


            //TODO: Print the capacity of the list to the console DONE

            Console.WriteLine($"numberList Capacity = { customNumberList.Capacity}");


            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this DONE           

            Populater(customNumberList);

            //TODO: Print the new capacity DONE

            Console.WriteLine($"numberList new Capacity = { customNumberList.Capacity}");
            

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that! DONE
            Console.WriteLine("What number will you search for in the number list?");

            NumberChecker(customNumberList);
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists DONE
            NumberPrinter(customNumberList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");

            OddKiller(customNumberList);
            NumberPrinter(customNumberList);


            
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            
            Console.WriteLine("------------------");
            Console.WriteLine("Sorted Evens!!");

            customNumberList.Sort();
            NumberPrinter(customNumberList);

            //TODO: Convert the list to an array and store that into a variable

            var myArray = customNumberList.ToArray();


            //TODO: Clear the list

            customNumberList.Clear();
            Console.WriteLine($"customNumberList Count = {customNumberList.Count}");
            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            
            for (int i = numberList.Count - 1; i >= 0; i--)
            {
                if(numberList[i] % 2 == 1)
                {
                    numberList.Remove(numberList[i]);
                }
            }
            
        }

        private static void NumberChecker(List<int> numberList)
        {
            bool isNumber;
            int userNumber;
            do
            {
                isNumber = int.TryParse(Console.ReadLine(), out userNumber);
                if (isNumber == false)
                {
                    Console.WriteLine("Invalid entry, please try again.");
                }
            }
            while (isNumber == false);
            

            if(numberList.Contains(userNumber))
            {
                Console.WriteLine("Yes, your number is present!");
            }
            else
            {
                Console.WriteLine("Sorry, your number is not present.");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(0, 50));
            }
            
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 50);
            }
            
        }        

        private static void ReverseArray(int[] array)
        {
            for (int i = 49; i >= 0; i--)
            {
                int value = array[i];
                Console.WriteLine(value);
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
