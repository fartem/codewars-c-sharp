using System;
using System.Linq;

namespace codewars_c_sharp.src.Kyu7
{
    // https://www.codewars.com/kata/5390bac347d09b7da40006f6
    public class JadenCasingStrings
    {
        private string Input;

        public JadenCasingStrings(string input)
        {
            Input = input;
        }

        public string Solution()
        {
            return string.Join(
                " ",
                Input
                    .Split(' ')
                    .Select(
                        word => new string(
                            word
                                .Remove(0, 1)
                                .Insert(0, word[0].ToString().ToUpper())
                                .ToArray()
                        )
                    )
            );
        }
    }
}
