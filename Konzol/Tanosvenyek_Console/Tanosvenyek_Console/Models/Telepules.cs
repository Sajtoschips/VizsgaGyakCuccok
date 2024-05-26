using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Tanosvenyek_Console.Models
{
    public class Telepules
    {
        public int id { get;private set; }
        public string nev { get;private set; }

        public Telepules(int id, string nev)
        {
            this.id = id;
            this.nev = nev;
        }

        public static List<Telepules>? LoadFromJson(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            string jsonAsString = sr.ReadToEnd();
            List<Telepules>? utvonalak = JsonSerializer.Deserialize<List<Telepules>>(jsonAsString);
            return utvonalak;
        }

        public static List<Telepules>? LoadFromCsv(string fileName)
        {
            List<Telepules> telepulesek = new List<Telepules>();
            StreamReader sr = new StreamReader(fileName);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] adatok = sr.ReadLine().Split(";");
                Telepules telepules = new Telepules(int.Parse(adatok[0]), adatok[1]);
                telepulesek.Add(telepules);
            }
            return telepulesek;
        }

    }

}
