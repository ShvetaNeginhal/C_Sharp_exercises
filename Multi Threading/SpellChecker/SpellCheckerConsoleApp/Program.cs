using System;
using System.Collections.Generic;
using System.IO;

using System.Collections.Concurrent;
namespace SpellCheckerConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dictionary =  File.ReadAllLines("en-US.dic");
            string[] wrongSentance = "with th Levenshtein distance algorithm".Split(' ');//, we implement approximate string matching. The difference between two strings is not represented as true or false, but as the number of steps needed to get from one to the other".Split(' ');
            
            //private ConcurrentDictionary<string,int> suggestedWords = new ConcurrentDictionary<string,int>();
           
            Dictionary<string, int> suggestedWords = new Dictionary<string, int>();
            foreach (string word in wrongSentance)
            {
                foreach (string dictWord in dictionary)
                {
                    if (dictWord.ToLower() == word.ToLower()) break;
                    if (dictWord.ToLower().StartsWith(word.ToLower()))
                       //|| word.ToLower().StartsWith(dictWord.ToLower()))
                    {
                        int distance = LevenshteinDistance.Compute(dictWord, word);
                        if(distance <= 3)
                            suggestedWords.Add(dictWord, distance);
                    }
                }
            }

            foreach (var item in suggestedWords.Keys)
            {

                Console.WriteLine($"{item}-{suggestedWords[item]}");
            }
        }
    }

    static class LevenshteinDistance
    {
        /// <summary>
        /// Compute the distance between two strings.
        /// </summary>
        public static int Compute(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1];

            // Step 1
            if (n == 0)
            {
                return m;
            }

            if (m == 0)
            {
                return n;
            }

            // Step 2
            for (int i = 0; i <= n; d[i, 0] = i++)
            {
            }

            for (int j = 0; j <= m; d[0, j] = j++)
            {
            }

            // Step 3
            for (int i = 1; i <= n; i++)
            {
                //Step 4
                for (int j = 1; j <= m; j++)
                {
                    // Step 5
                    int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;

                    // Step 6
                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost);
                }
            }
            // Step 7
            return d[n, m];
        }
    }
}
