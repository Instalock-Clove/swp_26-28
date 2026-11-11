namespace FirstOOP
{
    public class Kuh : Tier
    {
        string _name { get; set; } 
        string _colour { get; set; }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }

        public Kuh(string name, string colour, string lebensraum) : base(lebensraum)
        {
            if (string.IsNullOrEmpty(name))
                throw new InvalidDataException("Der Name darf nicht leer sein.");

            _name = name;
            _colour = colour;
        }
    }
}