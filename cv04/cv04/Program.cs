using System;

namespace cv04
{
    class Program
    {
        static void Main(string[] args)
        {
            string testText = "Toto je retezec predstavovany nekolika radky,\n"
+ "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
+ "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
+ "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
+ "posledni veta!";
            StringStat ss = new StringStat(testText);

            
            Console.WriteLine(testText + "\n");
            Console.WriteLine("Počet slov: "+ss.WordCount());
            Console.WriteLine("Počet řádků: " + ss.LineCount());
            Console.WriteLine("Počet vět: " + ss.SentenceCount());
            Console.Write("Nejdelší slovo: ");
            foreach(var longest in ss.LongestWords())
            {
                Console.Write(longest);
            }
            Console.WriteLine("");
            Console.Write("Nejkratší slovo: ");
            foreach (var shortest in ss.ShortestWords())
            {
                Console.Write(shortest);
            }
            Console.WriteLine("");
        }
    }
}
