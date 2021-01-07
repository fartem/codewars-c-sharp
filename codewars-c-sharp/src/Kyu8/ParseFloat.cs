using System;

namespace codewars_c_sharp.src.Kyu8
{
    // https://www.codewars.com/kata/57a386117cb1f31890000039
    public class ParseFloat
    {
        private object Input;

        public ParseFloat(object input)
        {
            Input = input;
        }

        public double? Solution()
        {
            if (Input is string)
            {
                try
                {
                    return double.Parse(Input as string);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            return null;
        }
    }
}
