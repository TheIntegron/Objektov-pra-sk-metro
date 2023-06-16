

using Spectre.Console;
using Objektové_pražské_metro;

string[] LinkaA = { "Nemocnice Motol", "Petřiny", "Nádraží Veleslavín", "Bořislavka", "Dejvická", "Hradčanská", "Malostranská", "Můstek", "Muzeum",
    "Náměstí Míru", "Jiřího z Poděbrad", "Flora", "Želivského", "Strašnická", "Skalka", "Depo Hostivař"};

string[] LinkaB = {"Zličín", "Stodůlky", "Luka", "Lužiny", "Hůrka", "Nové Butovice", "Jironice, Radlická", "Smíchovské nádraží", "Anděl", 
    "Karlovo náměstí", "Národní třída", "Můstek", "Náměstí Republiky", "FLorenc", "Křižíkova", "Invalidova", "Palmovka", "Českomoravská", "Vysočanská",
    "Kolbenova", "Hloubětín", "Rajská zahrada", "Černý Most" };

string[] LinkaC = {"Letňany", "Prosek", "Sřížkov", "Ládví", "Kobylisy", "nádraží Holešovice", "Vltavská", "Florenc", "Hlavní nádraží","Muzeum",
    "I.P. Pavlova", "Vyšehrad", "Pražského povstání", "Pankrác", "Budějovická", "Kačerov – Depo", "Kačerov", "Roztyly", "Chodov", "Opatov", "Háje" };

string[] LinkaD = { "Náměstí Míru", "Náměstí Bří Synků", "Olbrachtova", "Nádraží Krč", "Nemocnice Krč", "Nové Dvory", "Libuš", "Písnice", "Depo Písnice" };


AnsiConsole.Markup("[underline red]Hello[/] World!");

Console.WriteLine("\nZadej linku kterou chceš využít: ");
string volba = Console.ReadLine();
if(volba == "A")
{
    LinkaMetra linkaA = new LinkaMetra()
    { Nazev = "A", Barva = "zelená", AktivniStanice = true, Zastavky = LinkaA };
    linkaA.NastavLinku();
    Console.WriteLine("Chcete vypsat: \n1. všechny stanice \n2. první a poslední \n3. zjistit čas cesty");
    string volbaA = Console.ReadLine();
    if (volbaA == "1")
    {
        linkaA.VypisVsechnyStanice();
    }
    else if (volbaA == "2")
    {
        linkaA.VypisPrvniPosledni();
    }
    else if (volbaA == "3")
    {
        linkaA.CasCesty();
    }
}
else if (volba == "B")
{
    LinkaMetra linkaB = new LinkaMetra()
    { Nazev = "B", Barva = "žlutá", AktivniStanice = true, Zastavky = LinkaB };
    linkaB.NastavLinku();
    Console.WriteLine("Chcete vypsat: \n1. všechny stanice \n2. první a poslední \n3. zjistit čas cesty");
    string volbaB = Console.ReadLine();
    if (volbaB == "1")
    {
        linkaB.VypisVsechnyStanice();
    }
    else if (volbaB == "2")
    {
        linkaB.VypisPrvniPosledni();
    }
    else if (volbaB == "3")
    {
        linkaB.CasCesty();
    }
}
else if (volba == "C")
{
    LinkaMetra linkaC = new LinkaMetra()
    { Nazev = "C", Barva = "červená", AktivniStanice = true, Zastavky = LinkaC };
    linkaC.NastavLinku();
    Console.WriteLine("Chcete vypsat: \n1. všechny stanice \n2. první a poslední \n3. zjistit čas cesty");
    string volbaC = Console.ReadLine();
    if (volbaC == "1")
    {
        linkaC.VypisVsechnyStanice();
    }
    else if (volbaC == "2")
    {
        linkaC.VypisPrvniPosledni();
    }
    else if (volbaC == "3")
    {
        linkaC.CasCesty();
    }
}
else if (volba == "D")
{
    LinkaMetra linkaD = new LinkaMetra()
    { Nazev = "D", Barva = "modrá", AktivniStanice = false, Zastavky = LinkaD };
    linkaD.NastavLinku();
    Console.WriteLine("Chcete vypsat: \n1. všechny stanice \n2. první a poslední \n3. zjistit čas cesty");
    string volbaD = Console.ReadLine();
    if (volbaD == "1")
    {
        linkaD.VypisVsechnyStanice();
    }
    else if (volbaD == "2")
    {
        linkaD.VypisPrvniPosledni();
    }
    else if (volbaD == "3")
    {
        linkaD.CasCesty();
    }
}

