using FirstOOP;

namespace FirstOOP.Tests;


public class KuhTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Konstruktor_MitGueltigemNamen_ErstelltKuh()
    {
        var kuh = new Kuh("Berta", "Braun");

        Assert.That(kuh.Name, Is.EqualTo("Berta"));
        Assert.That(kuh.Colour, Is.EqualTo("Braun"));
    }

    [Test]
    public void Konstruktor_MitNullAlsName_WirftInvalidDataException()
    {
        Assert.Throws<InvalidDataException>(() => new Kuh(null!, "Braun"));
    }

    [Test]
    public void Konstruktor_MitLeeremName_WirftInvalidDataException()
    {
        Assert.Throws<InvalidDataException>(() => new Kuh("", "Braun"));
    }
}