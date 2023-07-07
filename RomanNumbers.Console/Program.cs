using RomanNumbers;

var quitter = false;

do
{
    Console.WriteLine("Saisissez un nombre arabe.");
    Console.Write("> ");
    var entrée = Console.ReadLine();
    if(entrée is null) continue;

    var nombre = uint.Parse(entrée);
    var résultat = ConvertisseurNombresRomains.Convertir(nombre);
    Console.WriteLine($"La version romaine de {entrée} est {résultat}");

    Console.WriteLine("Encore (y/N) ?");
    if (Console.ReadLine() != "y") quitter = true;
} while(!quitter);

