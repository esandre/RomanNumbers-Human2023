namespace RomanNumbers;

public static class ConvertisseurNombresRomains
{
    public static string Convertir(uint chiffreArabe)
        => chiffreArabe switch
           {
               1 => "I",
               _ => "II"
           };
}