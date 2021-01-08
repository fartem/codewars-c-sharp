using System;
using System.Text;

namespace codewars_c_sharp.src.Kyu6
{
    // https://www.codewars.com/kata/546f922b54af40e1e90001da
    public class ReplaceWithAlphabetPosition
    {
        private string Input;

        public ReplaceWithAlphabetPosition(string input)
        {
            Input = input;
        }

        public string Solution()
        {
            StringBuilder result = new StringBuilder();
            byte[] inputAsByteArray = Encoding.ASCII.GetBytes(Input);
            foreach (byte b in inputAsByteArray)
            {
                if (IsUpperCaseLetter(b))
                {
                    result.Append((b - 64).ToString() + " ");
                }
                else if (IsLowerCaseLetter(b))
                {
                    result.Append((b - 96).ToString() + " ");
                }
            }
            return result.ToString().Trim();
        }

        private bool IsUpperCaseLetter(int letter)
        {
            return letter > 64 && letter < 91;
        }

        private bool IsLowerCaseLetter(int letter)
        {
            return letter > 96 && letter < 123;
        }
    }
}
