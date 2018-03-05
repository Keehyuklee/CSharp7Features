using System;

namespace CSharp7
{
    class DigitSeperators
    {
        public void DigitSeperator()
        {
            //Compiler ignores "_". It just helps to improve readability.
            long numberOne = 10_000_000_000;
            long numberTwo = 10000000000;

            Console.WriteLine(numberOne); //Display 10000000000 on the Console.
            Console.WriteLine(numberTwo); //Display 10000000000 on the Console.

        }
    }
}
