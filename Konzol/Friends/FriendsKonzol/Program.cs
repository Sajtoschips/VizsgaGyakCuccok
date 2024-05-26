// See https://aka.ms/new-console-template for more information
using FriendsKonzol;
using FriendsKonzol.Models;





Console.WriteLine($"1.feladat: Évadok száma: {Solution.GetSeasonNumber()}");

Console.WriteLine($"2.feladat: Epizodok száma: {Solution.GetEpisodeNumber()}");


var hvList = Solution.GetEpisodeNameContains();
Console.WriteLine($"6.feladat: The one című részek: {hvList.Count},ezek az alábbiak:");
foreach (var title in hvList)
{
	Console.WriteLine($"\t{title}");
}


Console.WriteLine($"7.feladat: {Solution.GetTimeBetween()}");
