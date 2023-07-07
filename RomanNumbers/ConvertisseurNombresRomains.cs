
namespace RomanNumbers;

public static class ConvertisseurNombresRomains
{
    private static readonly IEnumerable<SymboleRomain> Symboles = new[]
    {
        new SymboleRomain('I', 1U, true),
        new SymboleRomain('V', 5U, false),
        new SymboleRomain('X', 10U, true),
        new SymboleRomain('L', 50U, false),
        new SymboleRomain('C', 100U, true)
    };

    private class Seuil
    {
        private readonly string _symbole;
        private readonly uint _valeur;
        
        public Seuil(SymboleRomain symboleDécimal, SymboleRomain symboleCourant)
        {
            _symbole = $"{symboleDécimal.Symbole}{symboleCourant.Symbole}";
            _valeur = symboleCourant.Valeur - symboleDécimal.Valeur;
        }

        public Seuil(SymboleRomain symboleDécimal)
        {
            _symbole = symboleDécimal.Symbole.ToString();
            _valeur = symboleDécimal.Valeur;
        }

        public bool Inclut(uint nombre) => _valeur <= nombre;

        public string Représenter(uint chiffreArabe)
        {
            return _symbole + Convertir(chiffreArabe - _valeur);
        }
    }

    static ConvertisseurNombresRomains()
    {
        var seuils = new List<Seuil>();
        var symboleDécimalPrécédent = Symboles.First();
        seuils.Add(new Seuil(symboleDécimalPrécédent));

        foreach (var symbole in Symboles.Skip(1))
        {
            seuils.Add(new Seuil(symboleDécimalPrécédent, symbole));
            seuils.Add(new Seuil(symbole));
            if(symbole.EstDécimal) symboleDécimalPrécédent = symbole;
        }

        Seuils = seuils.ToArray().Reverse().ToArray();
    }

    private static readonly IEnumerable<Seuil> Seuils;

    public static string Convertir(uint chiffreArabe)
    {
        if (chiffreArabe == 0) return string.Empty;
        var seuil = Seuils.First(seuil => seuil.Inclut(chiffreArabe));
        return seuil.Représenter(chiffreArabe);
    }
}
