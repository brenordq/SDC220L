namespace UserIntCalculator
{
    // The calculator class

    class Calculator
    {
        public int Add(int int1, int int2)
        {
            return int1 + int2;
        }

        public double Subtract(double float1, double float2)
        {
            return float1 - float2;
        }

        public double Multiply(double mult1, double mult2)
        {
            return mult1 * mult2;
        }

        public double Divide(double div1, double div2)
        {
            // Division safety logic can be handled directly by whoever calls the method, 
            // or return a raw division result.
            return div1 / div2;
        }
    }
}
