using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friends_Console
{
    public static class Solution
    {
        public static List<Season>? Seasons { get; set; } = Season.LoadFromJson("seasons.json").OrderBy(x => x.release_date).ToList(); //Az oredby nem kell csak azért kell mert hibás a json!
        public static List<Episode>? Episodes { get; set; } = Episode.LoadFromJson("episodes.json");



        public static int GetSeasonNumber()
        {
            return Seasons.Count;
        }

        public static List<string> GetContainsTheOneTitle()
        {
            List<string> megoldasok = new List<string>();
            foreach (var ep in Episodes)
            {
                if (ep.title.ToLower().Contains("the one"))
                {
                    megoldasok.Add(ep.title);
                }
            }
            return megoldasok;
        }
    }
}
