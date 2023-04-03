using System;

public class Kata
{
    public static string ToCamelCase(string str)
    {
        string[] words = str.Split(new char[] { '-', '_' });

        for (int i = 1; i < words.Length; i++)
        {
            words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
        }

        return string.Join("", words);
    }
}
