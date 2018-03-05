//Out Variable

namespace CSharp7
{
    class OutVariables
    {
        //Before C#7
        public double ConvertToDoubleBeforeCS7()
        {
            double converted;          
            double.TryParse("123.45", out converted);

            return converted;
        }

        //C#7
        public double ConvertToDoubleCS7()
        {
            //C#7 does not need to declair the variable before TryParse method.
            double.TryParse("123.45", out double converted);

            return converted;
        }
    }
}
