namespace RomanNumbers.Test;

public class RomanNumberTest
{
    [Fact(DisplayName = "ETANT DONNE le chiffre 1 " +
                        "QUAND je le convertis en nombres romains " +
                        "ALORS j'obtiens I")]
    public void Test1()
    {
        const uint chiffreArabe = 1;
        
        var nombreRomain = ConvertisseurNombresRomains.Convertir(chiffreArabe);
        
        Assert.Equal("I", nombreRomain);
    }

    [Fact(DisplayName = "ETANT DONNE le chiffre 2 " +
                        "QUAND je le convertis en nombres romains " +
                        "ALORS j'obtiens II")]
    public void Test2() // TODO : duplication 
    {
        const uint chiffreArabe = 2;

        var nombreRomain = ConvertisseurNombresRomains.Convertir(chiffreArabe);
        
        Assert.Equal("II", nombreRomain);
    }
}