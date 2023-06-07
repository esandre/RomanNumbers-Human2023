﻿namespace RomanNumbers;

public static class ConvertisseurNombresRomains
{
    public static string Convertir(uint chiffreArabe)
        => chiffreArabe switch
           {
               <= 3 => new string('I', (int)chiffreArabe),
               4    => "IV",
               5    => "V",
               6    => "VI",
               7    => "VII",
               _    => "VIII"
           };
}
