using System;

namespace codewars_c_sharp.src.Kyu7
{
    // https://www.codewars.com/kata/578553c3a1b8d5c40300037c
    public class OnesAndZeros
    {
        private int[] BinaryArray;

        public OnesAndZeros(int[] binaryArray)
        {
            BinaryArray = binaryArray;
        }

        public int Solution()
        {
            return Convert.ToInt32(
                string.Join("", BinaryArray),
                2
            );
        }
    }
}
