using AnagramSecond;
using NUnit.Framework;
using System.Collections.Generic;

namespace AnagramTest
{
    [TestFixture]
    public class AnagramTest
    {
        [Test]
        public void Empty_File_Should_Return_Exception()
        {
            List<string> anagramFile = new List<string>();
            Program anagram = new Program();
            anagram.ReadFile(anagramFile);
            Assert.IsNotEmpty(anagramFile);
        }
    }
}
