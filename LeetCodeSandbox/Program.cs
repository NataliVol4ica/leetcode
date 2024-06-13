using LeetCodeSandbox._1._1000._1._100;
using LeetCodeSandbox._1._1000._1._100._1._10;
using LeetCodeSandbox._1._1000._1._100._31._40;
using LeetCodeSandbox._1._1000._1._100._41._50;
using LeetCodeSandbox._1._1000._1._100._51._60;
using LeetCodeSandbox._1._1000._1._100._71._80;
using LeetCodeSandbox._1._1000._1._100._81._90;
using LeetCodeSandbox._1._1000._101._200._121._130;
using LeetCodeSandbox._1._1000._101._200._191._200;
using LeetCodeSandbox._1._1000._201._300;
using LeetCodeSandbox._1._1000._201._300._271._280;
using LeetCodeSandbox._1._1000._301._400._301._310;
using LeetCodeSandbox._1._1000._401._500._401._410;
using LeetCodeSandbox._1._1000._401._500._461._470;
using LeetCodeSandbox._1._1000._501._600._501._510;
using LeetCodeSandbox._1._1000._501._600._521._530;
using LeetCodeSandbox._1._1000._501._600._551._560;
using LeetCodeSandbox._1._1000._601._700._621._630;
using LeetCodeSandbox._1._1000._701._800._751._760;
using LeetCodeSandbox._1._1000._901._1000._931._940;
using LeetCodeSandbox._1._1000._901._1000._941._950;
using LeetCodeSandbox._1._1000._901._1000._971._980;
using LeetCodeSandbox._1._1000._901._1000._981._990;
using LeetCodeSandbox._1001._2000._1101._1200._1121._1130;
using LeetCodeSandbox._1001._2000._1101._1200._1131._1140;
using LeetCodeSandbox._1001._2000._1201._1300._1281._1290;
using LeetCodeSandbox._1001._2000._1501._1600._1541._1550;
using LeetCodeSandbox._1001._2000._1601._1700._1611._1620;
using LeetCodeSandbox._1001._2000._1601._1700._1691._1700;
using LeetCodeSandbox._1001._2000._1901._2000._1901._1910;
using LeetCodeSandbox._1001._2000._1901._2000._1971._1980;
using LeetCodeSandbox._1001._2000._1901._2000._1991._2000;
using LeetCodeSandbox._2001._3000._2001._2100._2071._2080;
using LeetCodeSandbox._2001._3000._2201._2300._2251._2260;
using LeetCodeSandbox._2001._3000._2201._2300._2261._2270;
using LeetCodeSandbox._2001._3000._2301._2400._2361._2370;
using LeetCodeSandbox._2001._3000._2501._2600._2591._2600;
using LeetCodeSandbox._2001._3000._2601._2700._2651._2660;

namespace LeetCodeSandbox;

public static class Program
{
    public static void Main()
    {
        try
        {
            IProblem problem = new Problem36();
            problem.Run();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }

        Console.ReadKey();
    }
}