public interface ICalculator
{
    /// <summary>
    /// Add two number together
    /// </summary>
    /// <param name="a">the value of the number a</param>
    /// <param name="b">the value of the number b</param>
    /// <returns>a + b</returns>
    double Add(double a, double b);
    /// <summary>
    /// Find the difference between two numbers
    /// </summary>
    /// <param name="a">the value of the number a</param>
    /// <param name="b">the value of the number b</param>
    /// <returns>a - b</returns>
    double Subtract(double a, double b);
    /// <summary>
    /// Multiply two numbers
    /// </summary>
    /// <param name="a">the value of the number a</param>
    /// <param name="b">the value of the number b</param>
    /// <returns>a * b</returns>
    double Multiply(double a, double b);
    /// <summary>
    /// Split a number into equal parts
    /// </summary>
    /// <param name="a">the value of the number a</param>
    /// <param name="b">the value of the number b</param>
    /// <returns>a / b</returns>
    double Divide(double a, double b);
}