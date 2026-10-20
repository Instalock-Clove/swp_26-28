using System.IO;
using FirstOOP;
using Xunit;

namespace FirstOOP.Tests
{
    public class KuhTests
    {
        [Fact]
        public void Konstruktor_MitGueltigemNamen_ErstelltKuh()
        {
            var kuh = new Kuh("Berta", "Braun");

            Assert.Equal("Berta", kuh.Name);
            Assert.Equal("Braun", kuh.Colour);
        }

        [Fact]
        public void Konstruktor_MitNullAlsName_WirftInvalidDataException()
        {
            Assert.Throws<InvalidDataException>(() => new Kuh(null, "Braun"));
        }

        [Fact]
        public void Konstruktor_MitLeeremName_WirftInvalidDataException()
        {
            Assert.Throws<InvalidDataException>(() => new Kuh("", "Braun"));
        }
    }
}