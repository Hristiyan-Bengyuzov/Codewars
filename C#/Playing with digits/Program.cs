using System;

public class DigPow
{
	public static long digPow(int n, int p)
	{
		int originalValue = n;
		int rev = 0;
		int sum = 0;

		while (n != 0) // reversing the number
		{
			rev = rev * 10 + n % 10;
			n /= 10;
		}

		while (rev != 0) // calculating the sum
		{
			int currentDigit = rev % 10;
			sum += (int)Math.Pow(currentDigit, p++);
			rev /= 10;
		}

		return sum % originalValue == 0 ? sum / originalValue : -1;
	}
}