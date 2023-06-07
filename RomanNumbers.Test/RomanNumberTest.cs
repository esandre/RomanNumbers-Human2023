namespace RomanNumbers.Test;

public class RomanNumberTest
{
    [Fact]
    public void Test1()
    {
        // ETANT DONNE le chiffre 1
        const uint chiffreArabe = 1;

        // QUAND je le convertis en nombres romains
        var nombreRomain = ConvertisseurNombresRomains.Convertir(chiffreArabe);

        // ALORS j'obtiens I
        Assert.Equal("I", nombreRomain);
    }
}