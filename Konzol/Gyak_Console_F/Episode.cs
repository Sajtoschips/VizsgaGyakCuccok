using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Friends_Console
{
    public class Episode
    {
        public int id { get; private set; }
        public int season { get; private set; }
        public int episode_in_season { get; private set; }
        public string title { get; private set; }
        public string directed_by { get; private set; }
        public string written_by { get; private set; }
        public string air_date { get; private set; }
        public float us_viewers_in_millions { get; private set; }

        public Episode(int id, int season, int episode_in_season, string title, string directed_by, string written_by, string air_date, float us_viewers_in_millions)
        {
            this.id = id;
            this.season = season;
            this.episode_in_season = episode_in_season;
            this.title = title;
            this.directed_by = directed_by;
            this.written_by = written_by;
            this.air_date = air_date;
            this.us_viewers_in_millions = us_viewers_in_millions;
        }

        public static List<Episode>? LoadFromJson(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            var lines = sr.ReadToEnd();
            return JsonSerializer.Deserialize<List<Episode>>(lines);
        }
    }

}
