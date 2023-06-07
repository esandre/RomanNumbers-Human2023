namespace RomanNumbers;

public static class ConvertisseurNombresRomains
{
    public static string Convertir(uint chiffreArabe)
    {
        if (chiffreArabe < 5)
            switch (chiffreArabe)
            {
                case <= 3:
                    return new string('I', (int)chiffreArabe);
                default:
                    return "IV";
            }
        else return "V";
    }
}
