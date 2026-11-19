namespace FirstOOP;

public class Animal
{
    private string _name = "";
    private string _colour = "";
    private DateTime _birthdate;

    public string Name
    {
        get { return _name; }
        protected set { _name = value; }
    }

    public string Colour
    {
        get { return _colour; }
        set { _colour = value; }
    }

    public DateTime Birthdate => _birthdate;

    public virtual void MakeSound()
    {
        Console.WriteLine("Animal Sound");
    }

    public virtual void MakeSound(int duration)
    {  
        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Animal Sound");
        }   
    }

    public void GetAge()
    {
        DateTime today = DateTime.Today;
        Console.WriteLine(today.Year - _birthdate.Year);
    }

    public Animal(string name, string colour, DateTime date)
    {
        _name = name;
        _colour = colour;
        _birthdate = date;
    }
}