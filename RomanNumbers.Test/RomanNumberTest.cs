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

    public static readonly IEnumerable<object[]> CasSymbolePlusUnité = new[]
    {
        new object[] { 'V', 5, 5 },
        new object[] { 'V', 5, 6 },
        new object[] { 'V', 5, 7 },
        new object[] { 'V', 5, 8 },
        new object[] { 'X', 10, 10 },
        new object[] { 'X', 10, 11 },
        new object[] { 'X', 10, 12 },
        new object[] { 'X', 10, 13 }
    };

    [Theory(DisplayName = "ETANT DONNE un symbole <symbole> valant <valeurDeBase> " +
                          "ET un nombre <nombreUnités> compris entre 0 et 3 au-dessus de cette valeur " +
                          "QUAND je le convertis en nombres romains " +
                          "ALORS j'obtiens <symbole> plus <(nombreUnités-valeurDeBase)> fois I")]
    [MemberData(nameof(CasSymbolePlusUnité))]
    public void TestSymbolePlusUnité(char symbole, uint valeurDeBase, uint nombreUnités)
    {
        var nombreRomain = ConvertisseurNombresRomains.Convertir(nombreUnités);

        var suiteDeI = new string('I', (int)(nombreUnités - valeurDeBase));
        Assert.Equal(symbole + suiteDeI, nombreRomain);
    }

    [Fact(DisplayName = "ETANT DONNE le chiffre 40 " +
                        "QUAND je le convertis en nombres romains " +
                        "ALORS j'obtiens XL")]
    public void TestQuarante()
    {
        const uint chiffreArabe = 40;

        var nombreRomain = ConvertisseurNombresRomains.Convertir(chiffreArabe);

        Assert.Equal("XL", nombreRomain);
    }

    [Fact(DisplayName = "ETANT DONNE le chiffre 41 " +
                        "QUAND je le convertis en nombres romains " +
                        "ALORS j'obtiens XLI")]
    public void TestQuaranteEtUn()
    {
        const uint chiffreArabe = 41;

        var nombreRomain = ConvertisseurNombresRomains.Convertir(chiffreArabe);

        Assert.Equal("XLI", nombreRomain);
    }

    [Fact(DisplayName = "ETANT DONNE le chiffre 50 " +
                        "QUAND je le convertis en nombres romains " +
                        "ALORS j'obtiens L")]
    public void TestCinquante()
    {
        const uint chiffreArabe = 50;

        var nombreRomain = ConvertisseurNombresRomains.Convertir(chiffreArabe);

        Assert.Equal("L", nombreRomain);
    }

    [Fact(DisplayName = "ETANT DONNE le chiffre 90 " +
                        "QUAND je le convertis en nombres romains " +
                        "ALORS j'obtiens XC")]
    public void TestQuatreVingtDix()
    {
        const uint chiffreArabe = 90;

        var nombreRomain = ConvertisseurNombresRomains.Convertir(chiffreArabe);

        Assert.Equal("XC", nombreRomain);
    }
}