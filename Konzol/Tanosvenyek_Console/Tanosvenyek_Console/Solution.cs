using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanosvenyek_Console.Models;

namespace Tanosvenyek_Console
{
    public static class Solution
    {
        public static List<Utvonal>? utvonalak { get; set; } = Utvonal.LoadFromCsv("Fajlok/utak.csv");
        public static List<Telepules>? telepulesek { get; set; } = Telepules.LoadFromCsv("Fajlok/telepulesek.csv");

        public static List<string> GetContainsHegyVolgy()
        {
            List<string> megoldasok = new List<string>();
            foreach (var ut in utvonalak)
            {
                if(ut.nev.ToLower().Contains("hegy") || ut.nev.ToLower().Contains("völgy"))
                {
                    megoldasok.Add(ut.nev);
                }
            }
            return megoldasok;
        }

        public static List<string> GetUtvonalByTelepules()
        {
            List<string> megoldasok = new List<string>();
            foreach (var telepules in telepulesek)
            {
                List<Utvonal> telUtvonalak = utvonalak.Where(x => x.telepulesid == telepules.id).ToList();
                if (telUtvonalak.Count >= 3)
                {
                    string sor = $"{telepules.nev}: {telUtvonalak.Count} db útvonal található - leghosszabb: {telUtvonalak.Max(x => x.hossz)} km";
                    megoldasok.Add(sor);
                }
            }
            return megoldasok;
        }

    }
}
