using TestDateFormat;
namespace Library.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void formatoCorrecta()
    {
        string expected = "2022-09-07"; 
        string date = "07/09/2022";
        Assert.AreEqual(expected, DateFormatter.ChangeFormat(date));
    }

    [Test]
    public void formatoIncorrecto(){
        string expected = "ERROR, formato incorrecto.";
        string date = "1111";
        Assert.AreEqual(expected, DateFormatter.ChangeFormat(date));
        
    }

    [Test]
    public void fechaEnBlanco(){
        string expected = "ERROR, se ingreso una fecha en blanco.";
        string date = " ";
        Assert.AreEqual(expected, DateFormatter.ChangeFormat(date));

    }
}