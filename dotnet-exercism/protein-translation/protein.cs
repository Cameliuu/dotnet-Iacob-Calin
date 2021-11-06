using System;
using System.Collections.Generic;
public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
        List<String> finalL = new List<String>() { };
        Dictionary<String, String> codons = new Dictionary<String, String>(){
            {"AUG" , "Methionine"},
            {"UUU" , "Phenylalanine"},
            {"UUC" , "Phenylalanine"},
            {"UUA" , "Leucine"},
            {"UUG" , "Leucine"},
            {"UCU" , "Serine"},
            {"UCC" , "Serine"},
            {"UCA" , "Serine"},
            {"UCG" , "Serine"},
            {"UAU" , "Tyrosine"},
            {"UAC" , "Tyrosine"},
            {"UGU" , "Cysteine"},
            {"UGC" , "Cysteine"},
            {"UGG" , "Tryptophan"}
            };
        string[] stops = { "UAA", "UAG", "UGA" };
        foreach (var stop in stops)
            if (strand.Contains(stop))
            {
                strand = strand.Remove(strand.IndexOf(stop));
                break;
            }
        Console.WriteLine(strand);
        while (strand.Length > 0)
            foreach (var element in codons)
                if (strand.Contains(element.Key) && strand.IndexOf(element.Key) == 0)
                {
                    finalL.Add(element.Value);
                    strand = strand.Remove(strand.IndexOf(element.Key), element.Key.Length);
                }
        string[] final = finalL.ToArray();
        return final;
    }
}