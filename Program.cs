/*
Base Converter from Coding Challenges
by Silvio Duka

Last modified date: 2018-02-23

In mathematics, a base is the number of different digits or combination of digits and letters that a system of counting uses to represent numbers. 
For example, the most common base used today is the decimal system. Because "dec" means 10, it uses the 10 digits from 0 to 9. 
A decimal number has base 10, a binary has base 2, an octal has base 8, etc. 

Given a non-negative integer & a base as input, create a program to convert the given decimal into the corresponding base. 

Some Examples: 
Input: 25 7 
Output: 34 

Input: 368 4 
Output: 11300 

Input: 78 3 
Output: 2220

Input: 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            long number = 65535;    // Insert a non-negative integer to convert
            int baseNumber = 16;    // Insert a non-negative base number (Max. base = 36)
            string result = "";     // Result string

            Console.Write($"Number {number} = ");

            while (number > 0)
            {
                result = digits.Substring((int)(number % baseNumber), 1) + result;

                number /= baseNumber;
            }

            Console.WriteLine($"{result} (base.{baseNumber})");
        }
    }
}

