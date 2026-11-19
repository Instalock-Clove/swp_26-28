using FirstOOP;

class Program
{
    static void Main()
    {
        Animal myAnimal = new Animal("Animal", "Brown", new DateTime(2018, 12, 1));
        myAnimal.MakeSound();

        Cat myCat = new Cat("Cookie", "Black", new DateTime(2014, 7, 14));
        myCat.MakeSound();
        myCat.GetAge();

        Cow myCow = new Cow("Cow0", "White", new DateTime(2015, 2, 1));
        myCow.MakeSound();

        Cow myCow1 = new Cow("Cow1", "Black", new DateTime(2008, 12, 1));
        Cow myCow2 = myCow; 

        Console.WriteLine(myCow.Name);
        myCow.Colour = "Brown";
        Console.WriteLine(myCow2.Colour); 

        Console.ReadKey();
    }
}