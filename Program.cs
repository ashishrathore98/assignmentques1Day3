using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment03_P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment 03-P-1  
            //TryParse method
            //string input;
            //Console.WriteLine("Enter a #: ");
            //input = Console.ReadLine();

            //int num;
            //if(int.TryParse(input, out num))  //int.TryParse converts the input string to integer, if successful returns true, otherwise false
            //{
            //    Console.WriteLine("Converted integer: " + num);
            //}
            //else
            //{
            //    Console.WriteLine("Error!!, please try again..");
            //}
            //Console.ReadKey();

            //Convert method

            // Example using TryParse method to convert string to int
            string intString = "190";
            int intValue;
            if (int.TryParse(intString, out intValue))
            {
                Console.WriteLine("TryParse successful. Converted integer value: " + intValue);
            }
            else
            {
                Console.WriteLine("TryParse failed. Invalid input string.");
            }

            // Example using Convert method to convert string to double
            string doubleString = "1.90";
            try
            {
                double doubleValue = Convert.ToDouble(doubleString);
                Console.WriteLine("Convert successful. Converted double value: " + doubleValue);
            }
            catch (FormatException)
            {
                Console.WriteLine("Convert failed. Invalid input format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Convert failed. Input value is too large or too small.");
            }

            // Example using Parse method to convert string to decimal
            string decimalString = "22.89";
            try
            {
                decimal decimalValue = decimal.Parse(decimalString);
                Console.WriteLine("Parse successful. Converted decimal value: " + decimalValue);
            }
            catch (FormatException)
            {
                Console.WriteLine("Parse failed. Invalid input format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Parse failed. Input value is too large or too small.");

            }
        }
    }
}