using System.Collections.Generic;
using System.Linq;

class Permutations
{
    public static List<string> SinglePermutations(string s) => Permute(s.ToCharArray(), s.Length);

    // Heap's algorithm
    static List<string> Permute(char[] arr, int size)
    {
        List<string> permutations = new List<string>();

        if (size == 1)
        {
            permutations.Add(new string(arr));
            return permutations;
        }

        for (int i = 0; i < size; i++)
        {
            permutations.AddRange(Permute(arr, size - 1));

            if (size % 2 == 1)
                (arr[0], arr[size - 1]) = (arr[size - 1], arr[0]);
            else
                (arr[i], arr[size - 1]) = (arr[size - 1], arr[i]);
        }

        return permutations.Distinct().ToList();
    }
}