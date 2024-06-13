namespace LeetCodeSandbox._1._1000._1._100._71._80
{
    public class Problem75 : IProblem
    {
        public void Run()
        {
            var colors1 = new int[] { 2, 0, 2, 1, 1, 0 };
            Console.WriteLine(Tools.Print(colors1));
            SortColors(colors1);
            Console.WriteLine(Tools.Print(colors1));

            var colors2 = new int[] { 2, 0, 1 };
            Console.WriteLine(Tools.Print(colors2));
            SortColors(colors2);
            Console.WriteLine(Tools.Print(colors2));
        }

        public void SortColors(int[] nums)
        {

        }
    }
}
