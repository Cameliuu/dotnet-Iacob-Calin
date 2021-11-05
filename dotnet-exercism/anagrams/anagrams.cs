using System;
using System.Collections.Generic;
public class Anagram
{
    public string baseWord;
    public Anagram(string baseWord)
    {
        this.baseWord = baseWord;
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        List<String> anagrams = new List<String>() { };
        SortedDictionary<char, int> freqBase = new SortedDictionary<char, int>() { };
        getDic(freqBase, baseWord);
        foreach (var elem in freqBase)
            Console.WriteLine($"{elem.Key}:{elem.Value}");
        Console.WriteLine("------------------------------------");
        foreach (var word in potentialMatches)
        {

            SortedDictionary<char, int> freqWord = new SortedDictionary<char, int>() { };
            getDic(freqWord, word);
            if (checkDic(freqBase, freqWord))
            {
                foreach (var elem in freqWord)
                    Console.WriteLine($"{elem.Key}:{elem.Value}");

                Console.WriteLine("------------------------------------");
                if (word.Length == baseWord.Length)
                {
                    int occurs = 0;
                    foreach (var chr in word.ToLower())
                        if (baseWord.ToLower().Contains(chr))
                        {

                            occurs++;
                        }
                    if (occurs == baseWord.Length && !(anagrams.Contains(word.ToLower())) && !baseWord.ToLower().Equals(word.ToLower()))
                        anagrams.Add(word);
                }
            }
        }
        string[] str = anagrams.ToArray();
        return str;
    }
    public void getDic(SortedDictionary<char, int> DIC, string word)
    {
        int fq;
        foreach (var chr in word.ToLower())
            if (!DIC.ContainsKey(chr))
            {
                DIC.Add(chr, 1);
            }
            else if (DIC.ContainsKey(chr))
            {
                DIC.TryGetValue(chr, out fq);
                DIC.Remove(chr);
                DIC.Add(chr, fq + 1);
            }
    }
    public bool checkDic(SortedDictionary<char, int> basew, SortedDictionary<char, int> word)
    {
        bool ok = true;
        foreach (var element in basew)
            if (ok && basew.GetValueOrDefault(element.Key) == word.GetValueOrDefault(element.Key))
                ok = true;
            else
            {
                ok = false;
            }
        return (ok) ? true : false;
    }
}