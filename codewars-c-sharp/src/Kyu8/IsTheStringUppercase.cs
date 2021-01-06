using System;

namespace codewars_c_sharp.src.Kyu8
{
    // https://www.codewars.com/kata/56cd44e1aa4ac7879200010b
    public class IsTheStringUppercase
    {
        private string Input;

        public IsTheStringUppercase(string input)
        {
            Input = input;
        }

        public bool Solution()
        {
            return Input == Input.ToUpper();
        }
    }
}
