using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace cv04
{
    public class StringStat
    {
        private string text;
        private string nointerpunction;
        public StringStat(string text)
        {
            this.text = text;
            nointerpunction = text.Replace(".", "").Replace(",", "").Replace("?", "").Replace("!", "").Replace("\n", " ").Replace("(", "").Replace(")", "");
        }

        public double WordCount()
        {
            char[] endofword = new char[] { ' ', '\r', '\n' };
            var count = text.Split(endofword).Length;
            return count;
        }
        public int LineCount()
        {
            var count = text.Split('\n').Length;
            return count;
        }
        public int SentenceCount()
        {
           
            Regex myRegex1 = new Regex("[^.!?;]*( [A-Z])[^.!?;]*");
            var result1 = myRegex1.Matches(text).Count;
            Regex myRegex2 = new Regex("[^.!?;]*(\n[A-Z])[^.!?;]*");
            var result2 = myRegex2.Matches(text).Count;
            Regex myRegex3 = new Regex("[^.!?;]*(\r[A-Z])[^.!?;]*");
            var result3 = myRegex3.Matches(text).Count;
            var results = result1 + result2 + result3;
            return results;   
        }
        public List<string> LongestWords()
        {
            string[] longestwords = nointerpunction.Split(' ');
            var sorted = longestwords.OrderBy(x => x.Length);

            var longest = new List<string>();
            var len = 0;
            var wlen = 0;
            foreach (var word in sorted)
            {
                if (word.Length >= len)
                {
                    len = word.Length;
                    longest.Add(word);
                    wlen = len;
                }

            }
            foreach (var word in sorted)
            {
                if (word.Length < wlen)
                {
                    longest.Remove(word);
                }
            }
            return longest;
        }
        public List<string> ShortestWords()
        {
            string[] shortestwords = nointerpunction.Split(' ');
            var sorted = shortestwords.OrderBy(aux => aux.Length);

            var shortest = new List<string>();
            var len = 100;

            foreach (var word in sorted)
            {
                if (word.Length <= len)
                {
                    len = word.Length;
                    shortest.Add(word + ", ");

                }

            }

            return shortest;
        }

        public string OftenWord()
        {
            string[] commonwords = nointerpunction.Split(' ');
            var dict = new Dictionary<string, int>();
            foreach (string word in commonwords)
            {
                if (dict.ContainsKey(word)) dict[word] += dict[word];
                else dict[word] = 1;
            }
            string mostcommon = "";
            foreach (KeyValuePair<string, int> kvp in dict)
            {
                if (kvp.Value == dict.Values.Max())
                {
                    mostcommon = kvp.Key;
                }
            }
            return mostcommon;
        }
        public List<string> Alphabet()
        { 
            List<string> words = new List<string>();
            string[] sorted = nointerpunction.Split(' ');
            foreach (var word in sorted)
            {
                words.Add(word);
            }
            var final = words.OrderBy(x => x).ToList();
            return final;
        }

    }
}