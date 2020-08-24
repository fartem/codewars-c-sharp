namespace codewars_c_sharp.src.Kyu8
{
    // https://www.codewars.com/kata/5a2b703dc5e2845c0900005a/train/csharp
    class CanWeDivideIt
    {
        private int Number;
        private int A;
        private int B;

        public CanWeDivideIt(int number, int a, int b)
        {
            Number = number;
            A = a;
            B = b;
        }

        public bool Result()
        {
            return Number % A == Number % B;
        }
    }
}
