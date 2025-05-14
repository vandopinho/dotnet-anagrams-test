using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Digite a primeira palavra: ");
        string word1 = Console.ReadLine();

        Console.Write("Digite a segunda palavra: ");
        string word2 = Console.ReadLine();

        if (AreAnagrams(word1, word2))
            Console.WriteLine("✅ As palavras são anagramas!");
        else
            Console.WriteLine("❌ As palavras NÃO são anagramas.");
    }

    static bool AreAnagrams(string a, string b)
    {
        a = a.ToLower().Replace(" ", "");
        b = b.ToLower().Replace(" ", "");

        if (a.Length != b.Length)
            return false;

        Dictionary<char, int> letterCount = new Dictionary<char, int>();

        foreach (char c in a)
        {
            if (letterCount.ContainsKey(c))
                letterCount[c]++;
            else
                letterCount[c] = 1;
        }

        foreach (char c in b)
        {
            if (!letterCount.ContainsKey(c))
                return false;

            letterCount[c]--;

            if (letterCount[c] < 0)
                return false;
        }

        return true;
    }
}
