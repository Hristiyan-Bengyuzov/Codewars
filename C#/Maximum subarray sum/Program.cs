public static class Kata
{
    // Kadane’s algorithm
    public static int MaxSequence(int[] arr)
    {
        int maxSoFar = int.MinValue, maxEndingHere = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            maxEndingHere += arr[i];

            if (maxSoFar < maxEndingHere)
                maxSoFar = maxEndingHere;

            if (maxEndingHere < 0)
                maxEndingHere = 0;
        }

        return maxSoFar == int.MinValue ? 0 : maxSoFar;
    }
}