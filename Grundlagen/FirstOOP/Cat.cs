namespace FirstOOP;

public class Cat : Animal
{
    public Cat(string name, string colour, DateTime date)
        : base(name, colour, date) { }

    public override void MakeSound()
    {
        Console.WriteLine("Miau");
    }
    public override void MakeSound(int duration)
    {
        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Miau");
        }
    }
}