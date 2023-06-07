namespace RomanNumbers;

public static class ConvertisseurNombresRomains
{
    public static string Convertir(uint chiffreArabe)
    {
        if (chiffreArabe <= 3)
        {
            return new string('I', (int)chiffreArabe);
        }
        
        return "IV";
    }
}
