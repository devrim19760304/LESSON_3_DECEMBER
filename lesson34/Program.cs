using System;

namespace lesson34
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // create a method to convert a decimal number to binary number
            BinaryConverter(3);

        }

        public static void BinaryConverter(int anyNumber)
        {
            string binaryText = "";

            while (anyNumber != 0)
            {
                if (anyNumber % 2 == 0)
                {
                    binaryText += "0";
                }
                else
                {
                    binaryText += "1";
                }
                anyNumber = anyNumber / 2;




            } //end of while loop 

            //this is reverse we need to reverse again
            //first get the text reverse is and convert to array and create a new Text 
            //possible also to create Convert to binary or array 
            binaryText = new string(binaryText.Reverse().ToArray());

            Console.WriteLine($"The number {anyNumber} binary {binaryText} ");
        }


    }
}