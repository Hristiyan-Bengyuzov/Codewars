using System;

public class PerfectPower
{
    public static (int, int)? IsPerfectPower(int n)
    {
        for (int @base = 2; @base <= Math.Sqrt(n); @base++)
        {
            for (int power = 2; power < 32; power++)
            {
                int currentNum = (int)Math.Pow(@base, power);

                // number is a perfect power
                if (currentNum == n) return (@base, power);

                // we should break if number is bigger than n or the int has overflown
                if (currentNum > n || currentNum == 0) break;
            }
        }

        return null;
    }
}