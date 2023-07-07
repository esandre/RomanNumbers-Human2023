using System.Reflection;

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

    [Fact(DisplayName = "ETANT DONNE un symbole <symbole> valant <valeurDeBase> " +
                          "ET un nombre <nombreUnités> compris entre 0 et 3 au-dessus de cette valeur " +
                          "QUAND je le convertis en nombres romains " +
                          "ALORS j'obtiens <symbole> plus <(nombreUnités-valeurDeBase)> fois I")]
    public void TestSymbolePlusUnité()
    {
        const string nomPropriétéContenantLesCas = nameof(CasSymbolePlusUnité);
        var myType = GetType();
        var propriétéContenantLesCas = myType
            .GetField(nomPropriétéContenantLesCas, 
                BindingFlags.Static | BindingFlags.Public);
        var valeurPropriétéContenantLesCas = (IEnumerable<object[]>) propriétéContenantLesCas?.GetValue(null)!;

        foreach (var cas in valeurPropriétéContenantLesCas)
        {
            var symbole = (char) cas[0];
            var valeurDeBase = Convert.ToUInt32(cas[1]);
            var nombreUnités = Convert.ToUInt32(cas[2]);

            var nombreRomain = ConvertisseurNombresRomains.Convertir(nombreUnités);

            var suiteDeI = new string('I', (int)(nombreUnités - valeurDeBase));
            Assert.Equal(symbole + suiteDeI, nombreRomain);
        }
    }
}