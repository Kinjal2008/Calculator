namespace Calculator
{
    public class Calculator: ICalculator
    {
        public int Add(int start, int amount)
        {
            return start + amount;
        }

        public int Divide(int start, int by)
        {
            if (by == 0)
            {
                return 0;
                //throw new ArgumentException("Cannot divide by zero!");
            }
            return start / by;
        }

        public int Multiply(int start, int by)
        {
            return start * by;
        }

        public int Subtract(int start, int amount)
        {
            return start - amount;
        }
    }
}
