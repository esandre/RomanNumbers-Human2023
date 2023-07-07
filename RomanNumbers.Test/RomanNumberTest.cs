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

    [Theory(DisplayName = "ETANT DONNE un symbole <symbole> valant <valeurDeBase> " +
                          "ET un nombre <nombreUnités> compris entre 0 et 3 au-dessus de cette valeur " +
                          "QUAND je le convertis en nombres romains " +
                          "ALORS j'obtiens <symbole> plus <(nombreUnités-valeurDeBase)> fois I")]
    [InlineData('V', 5, 5)]
    [InlineData('V', 5, 6)]
    [InlineData('V', 5, 7)]
    [InlineData('V', 5, 8)]
    [InlineData('X', 10, 10)]
    [InlineData('X', 10, 11)]
    [InlineData('X', 10, 12)]
    [InlineData('X', 10, 13)]
    public void TestSymbolePlusUnité(char symbole, uint valeurDeBase, uint nombreUnités)
    {
        var nombreRomain = ConvertisseurNombresRomains.Convertir(nombreUnités);

        var suiteDeI = new string('I', (int)(nombreUnités - valeurDeBase));
        Assert.Equal(symbole + suiteDeI, nombreRomain);
    }
}