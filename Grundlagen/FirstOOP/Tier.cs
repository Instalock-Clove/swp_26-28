namespace FirstOOP
{
    public class Tier
    {
        string _lebensraum { get; set; }
        public string Lebensraum
        {
            get { return _lebensraum; }
            set { _lebensraum = value; }
        }
        public Tier(string lebensraum)
        {
            if (string.IsNullOrEmpty(lebensraum))
                throw new InvalidDataException("Der Lebensraum darf nicht leer sein.");
            _lebensraum = lebensraum;
        }
    }
}
