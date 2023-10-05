using System.Collections.Generic;
using System.Linq;

public class Xbonacci
{
    public double[] Tribonacci(double[] signature, int n)
    {
        List<double> tribonacciNums = new List<double>(signature);

        for (int i = 3; i < n; i++)
            tribonacciNums.Add(tribonacciNums[i - 3] + tribonacciNums[i - 2] + tribonacciNums[i - 1]);

        return tribonacciNums.Take(n).ToArray();
    }
}