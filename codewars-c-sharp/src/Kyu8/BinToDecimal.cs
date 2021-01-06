using System;

namespace codewars_c_sharp.src.Kyu8
{
    // https://www.codewars.com/kata/57a5c31ce298a7e6b7000334
    public class BinToDecimal
    {
        private string Input;

        public BinToDecimal(string input)
        {
            Input = input;
        }

        public int Solution()
        {
            return Convert.ToInt32(Input, 2);
        }
    }
}
