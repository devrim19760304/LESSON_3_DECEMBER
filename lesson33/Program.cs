//in this lesson we studied the differences between static method and without static method 
// if we create a method without static key word we need to create an instance of our program class
// and then we can use our method

// you will see some funny methods below 


using System;
namespace lesson33
{

    internal class Program
    {
        static void Main(string[] args)
        {

            //now we make same with a method 

            //the method greeting is not static we need to create a program instance to use it 
            Console.WriteLine(new string('-', 100));
            Program program = new Program();
            string personName = "devrim";
            program.Greeting(personName);

            Console.WriteLine(new string('-', 100));

            //and create a static method which means we can call directly

            // first declare Netto income 
            decimal bruttoIncome = 34333m;
            decimal taxRate = 0.3m;
            decimal nettoIncome = NettoIncome(bruttoIncome, taxRate);

            //since it is not a void function we need to print out 
            Console.WriteLine("monthly income " + nettoIncome);
            Console.WriteLine(new string('-', 100));

            //since we return a value we can also find yearly income
            decimal yearNettoIncome = nettoIncome * 12;
            Console.WriteLine("yearly income :" + yearNettoIncome);

            Console.WriteLine(new string('-', 100));

            //and previous lesson find sum of number between start, end 
            //analyze what we need ? a starting number a accumulator and an end number
            SumOfNumbers(0, 200);


            //reverse a text 
            string someText="I am sure you will be great programmers";
            
            Console.WriteLine(reverseText(someText));


            










        }

        //not static method
        public void Greeting(string personName)
        {
            Console.WriteLine($"hello my name is {personName}");
        }

        //a static method
        public static decimal NettoIncome(decimal bruttoIncome, decimal taxRate)
        {
            decimal nettoIncome = bruttoIncome * (1 - taxRate);
            return nettoIncome;


        }

        //a static method
        //let us make first void then return a value
        public static void SumOfNumbers(int startNumber, int endNumber)
        {
            int sum = 0;
            for (int i = startNumber; i <= endNumber; i++)
            {
                sum += i;
            }
            Console.WriteLine($"the sum of number between from {startNumber} to {endNumber} is {sum}");
        }

        //reverse a string 
        //watch it is not a VOID 
        public static string reverseText(string anyText)

        {
            
            //IEnumerable<char>, we convert it to a string before returning
            string reversedText=new String(anyText.Reverse().ToArray());
            return reversedText;

        }
    }
}