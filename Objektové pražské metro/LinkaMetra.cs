using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

namespace Objektové_pražské_metro
{
    internal class LinkaMetra
    {
        public string Nazev { get; set; }
        public bool AktivniStanice { get; set; }
        public string Barva { get; set; }
        public string[] Zastavky { get; set; }


        public void VypisVsechnyStanice()
        {
            if (Nazev.Length > 0)
            {
                foreach (var jednaStanice in Zastavky)
                {
                    Console.WriteLine(jednaStanice);
                }
            }
        }
        public void VypisPrvniPosledni()
        {
            if (Zastavky.Length >= 2)
            {
                Console.WriteLine(Zastavky[0]);
                Console.WriteLine(Zastavky[Zastavky.Length - 1]);
            }
        }
        public void NastavLinku()
        {
            if (Barva == "zelená")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (Barva == "červená")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (Barva == "žlutá")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (Barva == "modrá")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            if (AktivniStanice == true)
            {
                Console.WriteLine($"Vítej v lince metra {Nazev}");
            }
            else
            {
                Console.WriteLine("Stanice je stále neaktivní");
            }
        }
        public void CasCesty()
        {
            VypisVsechnyStanice();
            Console.WriteLine("Vyber 1. stanici");
            string prvniStanice = Console.ReadLine();
            int indexPrvni = Array.IndexOf(Zastavky, prvniStanice);
            Console.WriteLine("---------------------");

            VypisVsechnyStanice();
            Console.WriteLine("Vyber 2. stanici");
            string druhaStanice = Console.ReadLine();
            int indexDruhy = Array.IndexOf(Zastavky, druhaStanice);
            Console.WriteLine("---------------------");
            int dobaCesty = (indexPrvni - indexDruhy) * -2;
            Console.WriteLine("Doba cesty: +-" + dobaCesty + " Minut/y");
        }
        public static void Main(string[] args)
        {
            AnsiConsole.Markup("[underline red]Hello[/]World!");
        }
    }
}
