using FriendsKonzol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FriendsKonzol
{
	public static class Solution
	{
		public static List<Season>? Seasons { get; set; } = Season.LoadFromJson("Files/seasons.json").OrderBy(x => x.releasedate).ToList(); //Az oredby nem kell csak azért kell mert hibás a json!
		public static List<Episode>? Episodes { get; set; } = Episode.LoadFromJson("Files/episodes.json");



		public static int GetSeasonNumber()
		{
			return Seasons.Count;
			
		}

		public static int GetEpisodeNumber()
		{
			return Episodes.Count;

		}

		
		public static List<string> GetEpisodeNameContains()
		{
			List<string> megoldasok = new List<string>();
			foreach (var ep in Episodes)
			{
				if (ep.title.ToLower().Contains("the one")) /*|| ut.nev.ToLower().Contains("völgy"))*/
				{
					megoldasok.Add(ep.title);
				}
			}
			return megoldasok;
		}



		public static string GetTimeBetween()
		{
			Season firsSeason = null;
			Season LastSeason = null;

			double max = 0;

			for (int i = 0; i < Seasons.Count - 1; i++)
			{
				double daysBetween = Math.Floor((Seasons[i +1].releasedate - Seasons[i].releasedate).TotalDays);
				if (daysBetween > max)
				{
					max = daysBetween;
					firsSeason = Seasons[i];
					LastSeason = Seasons[i + 1];
				}
			}

			return $"A legtöbb idő a(z) {firsSeason.id} {firsSeason.releasedate} és a(z) {LastSeason.id} {LastSeason.releasedate} közt telt el, {max} nap!";


		}

	}
}
