using System;
using System.Linq;

namespace codewars_c_sharp.src.Kyu7
{
    // https://www.codewars.com/kata/5259b20d6021e9e14c0010d4
    public class ReverseWords
    {
        private string Input;

        public ReverseWords(string input)
        {
            Input = input;
        }

        public string Solution()
        {
            return string.Join(
                " ",
                Input.Split(' ').Select(word => new string(word.Reverse().ToArray())).ToArray()
            );
        }
    }
}
