using System.Collections.Generic;
using System.Linq;
using System.Numerics;

public static class Kata
{
    public static List<Tuple<int, int>> FibDigits(int n)
    {
        if (n <= 2) return new List<Tuple<int, int>> { new Tuple<int, int>(1, 1) }; // edge case

        var numsByOccurences = new Dictionary<int, int>();
        var result = new List<Tuple<int, int>>();
        BigInteger a = 1;
        BigInteger b = 1;
        BigInteger c = 0;

        for (int i = 0; i < n - 2; i++) // getting n-th Fibonacci number
        {
            c = a + b;
            a = b;
            b = c;
        }

        foreach (var item in c.ToString()) // putting numbers by their occurences in a map
        {
            int currentNum = int.Parse(item.ToString());
            if (!numsByOccurences.ContainsKey(currentNum))
                numsByOccurences.Add(currentNum, 0);
            numsByOccurences[currentNum]++;
        }

        foreach (var (number, occurences) in numsByOccurences.OrderByDescending(n => n.Value).ThenByDescending(n => n.Key)) // adding data into result list
            result.Add(new Tuple<int, int>(occurences, number));

        return result;
    }
}