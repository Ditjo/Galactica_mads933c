using Galactica_mads933c;

Data data = new();

if (data.Sun.PlanetList == null) return;

Console.WriteLine("Planets");
foreach (Planet p in data.Sun.PlanetList)
{
    Console.WriteLine($"{p.Name} Type: {p.Type} Distance Sun: {p.Distance()} Pos {p}\n ");
    if (p.MoonList != null)
    {
        Console.WriteLine("\t*****Moons*****");
        foreach (Moon m in p.MoonList)
        {
            Console.WriteLine($"\t{m.Name} {m.Distance(p)}\n");
        }
    }

}
Console.WriteLine("Fuck Pluto");
