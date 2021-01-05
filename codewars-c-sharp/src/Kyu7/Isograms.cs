using System;
using System.Linq;

namespace codewars_c_sharp.src.Kyu7
{
    // https://www.codewars.com/kata/54ba84be607a92aa900000f1
    public class Isograms
    {
        private string Input;

        public Isograms(string input)
        {
            Input = input;
        }

        public bool Solution()
        {
            return Input
                .ToLower()
                .GroupBy(letter => letter)
                .Where(letter => letter.Count() > 1)
                .ToArray()
                .Length == 0;
        }
    }
}
