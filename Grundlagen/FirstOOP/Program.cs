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
        myCow.MakeSound(3);

        Cow myCow1 = new Cow("Cow1", "Black", new DateTime(2008, 12, 1));
        Cow myCow2 = myCow; 
        Cow myCow3 = new Cow("Cow3", new DateTime(2015, 2, 1));

        Console.WriteLine(myCow.Name);
        myCow.Colour = "Brown";
        Console.WriteLine(myCow2.Colour);
        Console.WriteLine(myCow3.Colour);

        var myAnimals = new List<Animal>();
        myAnimals.Add(myCat);
        myAnimals.Add(myCow);

        Console.ReadKey();
    }
}