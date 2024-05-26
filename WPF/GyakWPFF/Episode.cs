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
        public int episodeInSeason { get; private set; }
        public string title { get; private set; }
        public string directedBy { get; private set; }
        public string writtenBy { get; private set; }
        public string airDate { get; private set; }
        public float usViewersInMillions { get; private set; }

    }

}
