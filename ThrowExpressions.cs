using System;

namespace CSharp7
{
    class ThrowExpressions
    {
        public int ThrowExceptions()
        {
            //Throw expressions can be used in conditional operators and null coalescings.
            //Null oalescing
            String input = Console.ReadLine() ?? throw new Exception("Exception");

            //Conditional operator
            return int.TryParse("123", out int converted) ? converted : throw new Exception("Error");
        }
    }
}
