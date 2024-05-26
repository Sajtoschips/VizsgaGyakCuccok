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
        public int numberOfEpisodes { get;private set; }
        public string releaseDate { get;private set; }
    }
}
