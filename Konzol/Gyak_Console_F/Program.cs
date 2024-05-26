

using Friends_Console;
using System.Collections.Generic;

Console.WriteLine($"1. feladat: Autók száma: {Solution.GetSeasonNumber()}");


var hvList = Solution.GetContainsTheOneTitle();
Console.WriteLine($"6.feladat: Összesen {hvList.Count}-ba szerepel a The One szó, ezek az alábbiak:");
foreach (var nev in hvList)
{
    Console.WriteLine($"\t{nev}");
}
