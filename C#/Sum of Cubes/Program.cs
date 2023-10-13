using System.Linq;

public static class Kata
{
	public static long SumCubes(int n) => Enumerable.Range(1, n).Sum(x => (long)x * x * x);
}