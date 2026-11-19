namespace FirstOOP;

public class Cow : Animal
{
    public Cow(string name, string colour, DateTime date)
        : base(name, colour, date) { }

    public override void MakeSound()
    {
        Console.WriteLine("Muuuhhh");
    }
}