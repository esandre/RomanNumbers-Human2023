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

    [Theory(DisplayName = "ETANT DONNE un nombre <nombreUnités> compris entre 5 et 6 " +
                         "QUAND je le convertis en nombres romains " +
                         "ALORS j'obtiens V plus <(nombreUnités-5)> fois I")]
    [InlineData(5)]
    [InlineData(6)]
    public void TestCinqPlusUnité(uint nombreUnités)
    {
        // ETANT DONNE un nombre <n> compris entre 5 et 6

        // QUAND je le convertis en nombres romains
        var nombreRomain = ConvertisseurNombresRomains.Convertir(nombreUnités);

        // ALORS j'obtiens V plus <(n-5)> fois I
        var suiteDeI = new string('I', (int) nombreUnités - 5);
        Assert.Equal("V" + suiteDeI, nombreRomain);
    }
}