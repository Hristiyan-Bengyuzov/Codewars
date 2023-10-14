public static class Kata
{
	public static long RowSumOddNumbers(long n)
	{
		long start = n * n - (n - 1);
		long end = start + 2 * n;
		long sum = 0;

		for (long i = start; i < end; i += 2)
		{
			sum += i;
		}

		return sum;
	}
}