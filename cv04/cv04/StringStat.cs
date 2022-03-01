using System;
using System.Collections.Generic;
using System.Linq;

namespace cv04
{
    public class StringStat
    {
        private string text;
        private string nointerpunction;
        public StringStat(string text)
        {
            this.text = text;
            nointerpunction = text.Replace(".", "").Replace(",", "").Replace("?", "").Replace("!", "").Replace("\n", " ");
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
            char[] capitals = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] endofsentence = new char[] {'.','!','?'};
            int count = text.Split(endofsentence).Length;
            return count;
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
            // not done
            string[] commonwords = nointerpunction.Split(' ');
            var dict = new Dictionary<string, int>();
        }

    }
}
