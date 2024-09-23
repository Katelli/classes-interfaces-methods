public class Person
{
    public string? Name;
    public int? Age;

    public List<string>? Interests;

    public void BetterGreeting()
    {
        if(Interests == null || Interests.Count == 0)
        {
            Console.WriteLine($"Hello {Name}. You are {Age} years old. And you have no interests listed");
            return;
        }

        string values;

        if (Interests.Count == 1)
        {
            values = Interests[0];
        }
        else
        {
            values = string.Join(", ", Interests.Take(Interests.Count - 1)) + "& " + Interests.Last();
        }

        Console.WriteLine($"Hello {Name}. You are {Age} years old. And you enjoy {values}");
    }
}