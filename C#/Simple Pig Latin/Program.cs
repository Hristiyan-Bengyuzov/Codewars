using System;

public class Kata
{
	public static string PigIt(string str)
	{
		string[] arr = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);

		for (int i = 0; i < arr.Length; i++)
		{
			// variables
			string currentWord = arr[i];
			char firstChar = currentWord[0];

			if (char.IsPunctuation(firstChar)) continue; //  leave punctuation marks untouched

			currentWord = currentWord.Substring(1); // removing first character
			currentWord += $"{firstChar}ay"; // appending first character and "ay"

			arr[i] = currentWord;
		}

		return string.Join(' ', arr);
	}
}