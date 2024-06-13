namespace LeetCodeSandbox
{
    public static class Tools
    {
        public static string Print<T>(T[] items)
        {
            return $"[{{{string.Join(",", items.Select(v => v?.ToString()))}}}]";
        }
    }
}
