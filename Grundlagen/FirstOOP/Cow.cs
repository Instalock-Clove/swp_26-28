namespace FirstOOP;

public class Cow : Animal
{
    public Cow(string name, string colour, DateTime date)
        : base(name, colour, date) { }
    public Cow(string name, DateTime date)
        : base(name, "Brown", date) { }

    public override void MakeSound()
    {
        Console.WriteLine("Muuuhhh");
    }
    public override void MakeSound(int duration)
    {
        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Muuuhhh");
        }   
    }
}