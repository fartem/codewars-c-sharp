using System;

namespace codewars_c_sharp.src.Kyu8
{
    // https://www.codewars.com/kata/559ac78160f0be07c200005a
    public class NameShuffler
    {
        private string Input;

        public NameShuffler(string input)
        {
            Input = input;
        }

        public string Solution()
        {
            string[] nameData = Input.Split(' ');
            Array.Reverse(nameData);
            return string.Join(" ", nameData);
        }
    }
}
