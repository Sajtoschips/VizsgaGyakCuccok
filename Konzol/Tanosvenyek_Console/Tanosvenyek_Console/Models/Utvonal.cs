using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Tanosvenyek_Console.Models
{
    public class Utvonal
    {
        public int azon { get;private set; }
        public string nev { get;private set; }
        public double hossz { get;private set; }
        public int allomas { get;private set; }
        public double ido { get;private set; }
        public bool vezetes { get;private set; }
        public int telepulesid { get;private set; }

        public Utvonal(int azon, string nev, double hossz, int allomas, double ido, bool vezetes, int telepulesid)
        {
            this.azon = azon;
            this.nev = nev;
            this.hossz = hossz;
            this.allomas = allomas;
            this.ido = ido;
            this.vezetes = vezetes;
            this.telepulesid = telepulesid;
        }

        public static List<Utvonal>? LoadFromJson(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            string jsonAsString = sr.ReadToEnd();
            List<Utvonal>? utvonalak = JsonSerializer.Deserialize<List<Utvonal>>(jsonAsString);
            return utvonalak;
        }

        public static List<Utvonal>? LoadFromCsv(string fileName)
        {
            List<Utvonal> utvonalak = new List<Utvonal>();
            StreamReader sr = new StreamReader(fileName);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] adatok = sr.ReadLine().Split(";");
                Utvonal ut = new Utvonal(int.Parse(adatok[0]), adatok[1], double.Parse(adatok[2].Replace(".", ",")), int.Parse(adatok[3]), double.Parse(adatok[4].Replace(".", ",")), bool.Parse(adatok[5]), int.Parse(adatok[6]));
                utvonalak.Add(ut);
            }
            return utvonalak;
        }

    }

}
