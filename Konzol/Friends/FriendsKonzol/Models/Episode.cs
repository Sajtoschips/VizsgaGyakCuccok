using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FriendsKonzol.Models
{
	public class Episode
	{

	
		
			public string title { get; private set; }
			public string id { get; private set; }
			public string image { get; private set; }
			public string plot { get; private set; }
			public string link { get; private set; }
			public string season { get; private set; }

		public Episode(string title, string id, string image, string plot, string link, string season)
		{
			this.title = title;
			id = id;
			this.image = image;
			this.plot = plot;
			this.link = link;
			this.season = season;
		}

		public static List<Episode> LoadFromJson(string fileName)
		{
			StreamReader sr = new StreamReader(fileName);
			string json = sr.ReadToEnd();
			return JsonSerializer.Deserialize<List<Episode>>(json);
		}



	}
}
