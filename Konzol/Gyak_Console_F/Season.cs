using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Friends_Console
{
    public class Season
    {
        public int id { get; set; }
        public int number_of_episodes { get;private set; }
        public DateTime release_date { get;private set; }

        public Season(int id, int number_of_episodes, DateTime release_date)
        {
            this.id = id;
            this.number_of_episodes = number_of_episodes;
            this.release_date = release_date;
        }

        public static List<Season>? LoadFromJson(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            var lines = sr.ReadToEnd();
            return JsonSerializer.Deserialize<List<Season>>(lines);
        }
    }
}
