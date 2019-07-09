using System.Collections.Generic;
using System.IO;

namespace AnagramSecond
{
    public class Program
    {
        public List<string> ReadFile(List<string> anagramsList)
        {
            var file = File.ReadAllLines(@"C:\Users\rdaniellagomez\anagrams.txt");
            foreach (string line in file)
            {
                var words = line.Split(' ');
                foreach (var word in words)
                {
                    anagramsList.Add(word);
                }
            }
            return anagramsList;
        }
        static void Main(string[] args)
        {
        }
    }
}
