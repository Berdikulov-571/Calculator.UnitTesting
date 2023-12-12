namespace Calculator.UnitTesting
{
    public static class Mathematics
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Dividge(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Value cannot be zero");
            }

            return a / b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}