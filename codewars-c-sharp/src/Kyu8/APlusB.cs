using System;

namespace codewars_c_sharp.src.Kyu8
{
    // https://www.codewars.com/kata/5512a0b0509063e57d0003f5
    public class APlusB
    {
        private byte FirstByte;
        private byte SecondByte;

        public APlusB(byte firstByte, byte secondByte)
        {
            FirstByte = firstByte;
            SecondByte = secondByte;
        }

        public byte Solution()
        {
            int c = (FirstByte + SecondByte);
            return (byte) c;
        }
    }
}
