using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int DuplicateCount(string str)
    {
        str = str.ToLower(); // case-insensitive
        var charsByOccurences = new Dictionary<char, int>();

        foreach (var item in str)
        {
            if (!charsByOccurences.ContainsKey(item))
                charsByOccurences.Add(item, 0);
            charsByOccurences[item]++;
        }

        return charsByOccurences.Count(c => c.Value > 1); // number of duplicates
    }
}