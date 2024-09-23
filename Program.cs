namespace classes_interfaces_methods;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.Name = "John Doe";
        person.Age = 32;
        List<string> interests = new List<string>(){
            "Watching TV ",
            "Programming "
        };
        person.Interests = interests;
        person.BetterGreeting();

        Console.WriteLine("\n");

        Calculator calculator = new Calculator();

        bool checkSomeValue = true;
        Console.WriteLine(checkSomeValue == false);

        Console.WriteLine("\n");

        Console.WriteLine("Please choose an operator( + , - , * , / ):");
        string? symbol  = Console.ReadLine();
        Console.WriteLine("Please write your first number");
        string? inputA = Console.ReadLine();
        Console.WriteLine("Please write your second number");
        string? inputB = Console.ReadLine();
        if(double.TryParse(inputA, out double a) && double.TryParse(inputB, out double b))
        {
            switch(symbol)
            {
                case "+":
                Console.WriteLine($"Sum: {calculator.Add(a, b)}");
                break;

                case "-":
                Console.WriteLine($"Sum: {calculator.Subtract(a, b)}");
                break;

                case "*":
                Console.WriteLine($"Sum: {calculator.Multiply(a, b)}");
                break;

                case "/":
                Console.WriteLine($"Sum: {calculator.Divide(a, b)}");
                break;

                default:
                Console.WriteLine("Please choose a valid operator ( + , - , * , / ) and two numbers");
                break;
            }
        }
    }
}