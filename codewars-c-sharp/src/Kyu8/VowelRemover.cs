using System;
using System.Text.RegularExpressions;

namespace codewars_c_sharp.src.Kyu8
{
    // https://www.codewars.com/kata/5547929140907378f9000039
    public class VowelRemover
    {
        private string Input;

        public VowelRemover(string input)
        {
            Input = input;
        }

        public string Solution()
        {
            return Regex.Replace(
                Input,
                "[aeiou]",
                ""
            );
        }
    }
}
