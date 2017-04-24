namespace SampleService
{
    public class Calculator : ICalculator
    {
        public string TestConnection()
        {
            return "OK";
        }

        public double Addition(double a, double b)
        {
            return a + b;
        }

        public double Subtraction(double a, double b)
        {
            return a - b;
        }

        public double Multiplication(double a, double b)
        {
            return a*b;
        }

        public double Division(double a, double b)
        {
            return a/b;
        }
    }
}