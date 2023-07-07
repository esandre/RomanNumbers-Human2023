namespace RomanNumbers.Test;

public class RomanNumberTest
{
    [Theory(DisplayName = "ETANT DONNE le chiffre <nombreUnités> " +
                        "QUAND je le convertis en nombres romains " +
                        "ALORS j'obtiens <nombreUnités> fois I")]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void TestUnité(uint nombreUnités)
    {
        var nombreRomain = ConvertisseurNombresRomains.Convertir(nombreUnités);

        var résultatAttendu = new string(Enumerable.Repeat('I', (int)nombreUnités).ToArray());
        Assert.Equal(résultatAttendu, nombreRomain);
    }

    [Fact(DisplayName = "ETANT DONNE le chiffre 4 " +
                          "QUAND je le convertis en nombres romains " +
                          "ALORS j'obtiens IV")]
    public void TestQuatre()
    {
        const uint chiffreArabe = 4;
        
        var nombreRomain = ConvertisseurNombresRomains.Convertir(chiffreArabe);
        
        Assert.Equal("IV", nombreRomain);
    }

    [Fact(DisplayName = "ETANT DONNE le chiffre 9 " +
                        "QUAND je le convertis en nombres romains " +
                        "ALORS j'obtiens IX")]
    public void TestNeuf()
    {
        const uint chiffreArabe = 9;

        var nombreRomain = ConvertisseurNombresRomains.Convertir(chiffreArabe);

        Assert.Equal("IX", nombreRomain);
    }

    [Theory(DisplayName = "ETANT DONNE un nombre <nombreUnités> compris entre 5 et 8 " +
                          "QUAND je le convertis en nombres romains " +
                          "ALORS j'obtiens V plus <(nombreUnités-5)> fois I")]
    [InlineData(5)]
    [InlineData(6)]
    [InlineData(7)]
    [InlineData(8)]
    public void TestCinqPlusUnité(uint nombreUnités)
    {
        var nombreRomain = ConvertisseurNombresRomains.Convertir(nombreUnités);

        var suiteDeI = new string('I', (int)nombreUnités - 5);
        Assert.Equal("V" + suiteDeI, nombreRomain);
    }

    [Theory(DisplayName = "ETANT DONNE un nombre <nombreUnités> compris entre 10 et 13 " +
                          "QUAND je le convertis en nombres romains " +
                          "ALORS j'obtiens X plus <(nombreUnités-10)> fois I")]
    [InlineData(10)]
    [InlineData(11)]
    [InlineData(12)]
    [InlineData(13)]
    public void TestDixPlusUnité(uint nombreUnités)
    {
        var nombreRomain = ConvertisseurNombresRomains.Convertir(nombreUnités);

        var suiteDeI = new string('I', (int)nombreUnités - 10);
        Assert.Equal("X" + suiteDeI, nombreRomain);
    }
}