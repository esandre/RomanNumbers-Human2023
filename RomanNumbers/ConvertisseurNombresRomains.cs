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
               < 40  => "X" + Convertir(chiffreArabe - 10),
               < 50  => "XL" + Convertir(chiffreArabe - 40),
               _    => "L" + Convertir(chiffreArabe - 50)
           };
}
