using System.Linq;
using System.Text.RegularExpressions;

public static class Kata
{
    public static int CountSmileys(string[] smileys) => smileys.Count(s => new Regex(@"^[:;][-~]?[)D]$").IsMatch(s));
}