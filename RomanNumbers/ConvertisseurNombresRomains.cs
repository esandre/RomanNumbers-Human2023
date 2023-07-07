namespace RomanNumbers;

public static class ConvertisseurNombresRomains
{
    public static string Convertir(uint chiffreArabe)
        => chiffreArabe switch
           {
               <= 3 => new string('I', (int)chiffreArabe),
               4    => "IV",
               < 9  => "V" + Convertir(chiffreArabe - 5),
               9    => "IX",
               10    => "X",
               _    => "X" + Convertir(chiffreArabe - 10),
           };
}
