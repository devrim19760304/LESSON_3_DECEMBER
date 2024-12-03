//in this small tutorial we studied how to use a for loop 
// to find sum between start-end numbers 
// we have not use any seperate method. 


using System;
using System.Runtime.Serialization;
namespace lesson32
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //our aim is to find sum of numbers between start- end 
            //start with create start -finish

            int startNumber = 0;
            int endNumber = 100;
            //we initialize now sum 
            int sum = 0;

            for (int i = startNumber; i <= endNumber; i++)
            {

                sum += i;
                // we add counter to our sum.
            }
            //we console out our sum 
            // please remember we added this line after our loop is done. 
            //let us create a nice text format             
            
            //watch we use a new string format 
            //vertabim interpolated string 
            string sumText= $@"
            the sum of Numbers
            between {startNumber} - {endNumber}
            The result : {sum}
            ";
            Console.WriteLine(sumText);

            //and now let us find sum of odd number between given interval
            //first we create an empty accumulator 
            int acc=0;
            for (int i = startNumber; i <= endNumber; i++)
            {
                // i add a condition by using modus 
                // our condition add if the number is odd
                if (i%2==1)
                {
                    acc+=i;

                }
            }

            Console.WriteLine($"the sum of odd numbers between {startNumber} - {endNumber} is {acc}");




        }
    }
}