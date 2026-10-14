using System;
using System.Collections.Generic;
using System.Text;

namespace FirstOOP
{
    public class Kuh
    {
        string _name { get; set; } // Private field for the name of the cow
        string _colour { get; set; } // Private field for the colour of the cow

        public string Name
        {
            get { return _name; } // Public property to get the name of the cow
            set { _name = value; } // Public property to set the name of the cow
        }
        public string Colour
        {
            get { return _colour; } // Public property to get the colour of the cow
            set { _colour = value; } // Public property to set the colour of the cow
        }
        // Constructor to initialize the cow's name and colour
        public Kuh(string name, string colour)
        {
            _name = name;
            _colour = colour;
        }
    }
}
