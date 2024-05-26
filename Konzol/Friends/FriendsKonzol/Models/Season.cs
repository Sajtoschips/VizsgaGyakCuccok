using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FriendsKonzol.Models
{
	public class Season
	{

		
		
		
			public int id { get; private set; }
			public int number_of_episodes { get; private set; }
			public DateTime releasedate { get; private set; }

		public Season(int id, int number_of_episodes, DateTime releasedate)
		{
			this.id = id;
			this.number_of_episodes = number_of_episodes;
			this.releasedate = (releasedate);
		}


		public static List<Season> LoadFromJson(string fileName)
		{
			StreamReader sr = new StreamReader(fileName);
			string json = sr.ReadToEnd();
			return JsonSerializer.Deserialize<List<Season>>(json);
		}





	}
}
