//in this lesson we have studied c# arrays and loop through array using for and foreach
//additional we have seen how we can create a new array using "CLONE" method
//this method allowed us create a new array without changing the original array

using System;
using System.Threading.Tasks.Dataflow;
namespace lesson31
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //some other data types 
            //Array 
            //a number array 
            int[] numberArray = { 1, 2, 3, 4, 6, 8, 4, 8 };

            //iterate the array 

            foreach (var value in numberArray)
            {
                Console.WriteLine(value);

            }

            //exercise try to find total sum of array 
            int totalSum = 0;

            foreach (var value in numberArray)
            {
                totalSum += value;
                Console.WriteLine(value);

            }


            Console.WriteLine($"Total Sum of Array {totalSum}");

            //string array 
            string[] fruits = {
                "Lemon",
                "Apple",
                "Kiwi",
                "Fig",
                "Date",
                "Banana",
                "Grape",
                "Cherry",
                "Elderberry",
                "Honeydew"
            };


            //how to loop throug this array
            //method 1 we can use length and index  with for loop 

            int fruitsArraySize = fruits.Length;

            //for loop 
            for (var i = 0; i < fruitsArraySize; i++)
            {
                Console.WriteLine(fruits[i]);
            }

            //also let us sort this array 
            // for same array we can use array sort method
            //Array.Sort(fruits);

            //but now we have problem we just destroyed our original array 
            //so can we just make new array like this? 
            // string[] sortedFruitsArray = fruits;

            //the problem here even if we copy this will not solve
            //the problem since both arrays are in same memory address

            //we need a new command 
            string[] sortedFruitsArray = (string[])fruits.Clone();
            //now we created a new array 

            //and now we can sort this array 
            Array.Sort(sortedFruitsArray);



            //add a new line 
            Console.WriteLine("-------------------------------------");
            //for loop 
            for (var i = 0; i < sortedFruitsArray.Length; i++)
            {
                Console.WriteLine(sortedFruitsArray[i] + "-----" + fruits[i]);
            }


            //this method is a bit long let us use other method loop through an array
            //foreach 

            Console.WriteLine(new string('*', 100));

            foreach (string i in fruits)
            {
                Console.WriteLine(i);
            }











        }
    }
}