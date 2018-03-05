namespace CSharp7
{
    class ExpressionBodies
    {
        //Expression Bodies can improve readability and make codes short.
        //Before C#7
        public int addOneBeforeCS7(int a)
        {
            return a++;
        }

        //C#7
        public int addOneCS7(int a) => a++;
    }
}
