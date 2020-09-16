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
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays

            // Create an integer Array of size 50
            int[] myArray = new int[50];


            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(myArray);

            //Print the first number of the array
            Console.WriteLine($"First number in the array: {myArray[0]}");

            //Print the last number of the array
            Console.WriteLine($"Last number in the array: {myArray[49]}");

            Console.WriteLine("All Numbers Original");

            //Use this method to print out your numbers from arrays or lists
            NumberPrinter(myArray);

            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */

            Console.WriteLine("All Numbers Reversed:");
           

            Console.WriteLine("---------REVERSE CUSTOM------------");

            ReverseArray(myArray);
            NumberPrinter(myArray);

            Console.WriteLine("-------------------");

            
            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");

            SortedArray(myArray);
            NumberPrinter(myArray);

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            ThreeKiller(myArray);
            NumberPrinter(myArray);

            Console.WriteLine("-------------------");


            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List

            List<int> myList = new List<int>();


            //Print the capacity of the list to the console
            Console.WriteLine($"List Capacity before populating {myList.Count}");

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(myList);
            NumberPrinter(myList);

            //Print the new capacity
            Console.WriteLine($"List Capacity after populating {myList.Count}");

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            //NumberPrinter();
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Odds Only!!");
            
            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Odds!!");
            
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            

            //Clear the list
            

            #endregion
        }

        private static void SortedArray(int[] numArray)
        {
            int temp;
            Console.WriteLine("----Sorted Array----");
            for (int i = 0; i < numArray.Length - 1; i++)
            {
                for (int j = i + 1; j < numArray.Length; j++)

                    if (numArray[j] < numArray[i])
                    {
                        temp = numArray[i];
                        numArray[i] = numArray[j];
                        numArray[j] = temp;
                    }

            }
        }
        

        private static void ThreeKiller(int[] numbers)
        {
            for(int i =0; i<numbers.Length;i++)
            {
                if(numbers[i]%3==0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(100));//Setting Max value to 100 
            }
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i =0; i<50;i++)
            {
                numbers[i] = rng.Next(100); //setting max value to 100
            }

        }        

        private static void ReverseArray(int[] array)
        {
            int temp;
            int len = array.Length;
            Console.WriteLine("-----Reversed Array-----");

            for (int i = 0; i <= (len / 2); i++)
            {
                temp = array[i];
                array[i] = array[len - (i + 1)];
                array[len - (i + 1)] = temp;
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

        private static void NumberPrinter(int[] numArray)
        {
            foreach(var num in numArray)
            {
                Console.WriteLine(num);
            }
        }


        private static void NumberPrinter(List<int> numList)
        {
            foreach (var num in numList)
            {
                Console.WriteLine(num);
            }
        }
    }

}
