namespace LeetCodeSandbox._1._1000._201._300._271._280
{
    public class Problem271 : IProblem
    {
        public void Run()
        {
            Console.WriteLine(Tools.Print(Decode(Encode(new string[] { "leet", "code", "love", "you" }))));
            Console.WriteLine(Tools.Print(Decode(Encode(new string[] { "we", "say", ":", "yes" }))));
        }

        string qD = ",";
        public string Encode(IList<string> strs)
        {
            int n = strs.Count;
            var lengthes = strs.Select(s => s.Length.ToString());
            var lengthesStr = string.Join(qD, lengthes);
            var mergedStrs = string.Join("", strs);
            var result = $"{n}{qD}{lengthesStr}{qD}{mergedStrs}";
            return result;
        }

        public List<string> Decode(string s)
        {
            int iofN = s.IndexOf(qD);
            string nSubstr = s.Substring(0, iofN);
            int n = int.Parse(nSubstr);

            int iofL = iofN;
            int iofLnew;
            int[] lengthes = new int[n];
            for (int i = 0; i < n; i++)
            {
                iofLnew = s.IndexOf(qD, iofL + 1);
                string lSubstr = s.Substring(iofL + 1, iofLnew - (iofL + 1));
                lengthes[i] = int.Parse(lSubstr);
                iofL = iofLnew;
            }

            List<string> result = new List<string>(n);

            int strInd = iofL;
            for (int i = 0; i < n; i++)
            {
                if (i == n - 1)
                {
                    result.Add(s.Substring(iofL + 1));
                }
                else
                {
                    result.Add(s.Substring(iofL + 1, lengthes[i]));
                    iofL += lengthes[i];
                }
            }

            return result;
        }
    }
}
