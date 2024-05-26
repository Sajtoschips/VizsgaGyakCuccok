// See https://aka.ms/new-console-template for more information
using Tanosvenyek_Console;

var hvList = Solution.GetContainsHegyVolgy();
Console.WriteLine($"6.feladat: Összesen {hvList.Count} tanösvény van, melynek neve tartalmazza a hegy vagy völgy szót, ezek az alábbiak:");
foreach (var nev in hvList)
{
    Console.WriteLine($"\t{nev}");
}

Console.WriteLine("\n7.feladat: Útvonalak településenként:");
var telList = Solution.GetUtvonalByTelepules();
foreach (var sor in telList)
{
    Console.WriteLine($"\t{sor}");
}