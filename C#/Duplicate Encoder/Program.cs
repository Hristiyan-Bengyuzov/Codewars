using System.Collections.Generic;

public class Kata
{
    public static string DuplicateEncode(string word)
    {
        Dictionary<char, int> charsByOccurences = new Dictionary<char, int>();
        word = word.ToLower(); // ignore capitalization

        for (int i = 0; i < word.Length; i++) // cycle for handling duplicates
        {
            if (!charsByOccurences.ContainsKey(word[i]))
                charsByOccurences.Add(word[i], 0);
            charsByOccurences[word[i]]++;
        }

        string result = string.Empty;

        for (int i = 0; i < word.Length; i++)
            result += charsByOccurences[word[i]] > 1 ? ')' : '(';

        return result;
    }
}