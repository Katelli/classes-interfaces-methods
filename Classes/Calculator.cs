public class Calculator : ICalculator
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {
        if(b == 0 || b.Equals(0)) 
        {
            throw new Exception("Cannot divide by 0!");
            //Console.WriteLine("Cannot divide by 0");
        }
        return a / b;
    }
}