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
        // ETANT DONNE le chiffre 4
        const uint chiffreArabe = 4;
        
        // QUAND je le convertis en nombres romains
        var nombreRomain = ConvertisseurNombresRomains.Convertir(chiffreArabe);

        // ALORS j'obtiens IV
        Assert.Equal("IV", nombreRomain);
    }

    [Fact(DisplayName = "ETANT DONNE le chiffre 5 " +
                         "QUAND je le convertis en nombres romains " +
                         "ALORS j'obtiens V")]
    public void TestCinq()
    {
        // ETANT DONNE le chiffre 5
        const uint chiffreArabe = 5;

        // QUAND je le convertis en nombres romains
        var nombreRomain = ConvertisseurNombresRomains.Convertir(chiffreArabe);

        // ALORS j'obtiens V
        Assert.Equal("V", nombreRomain);
    }
}