using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Esercizio;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Program p = new Program();
            List<string> ris = p.search(Path.GetFullPath("./file.csv"), 2, "Alberto");
            Assert.AreEqual("3,Verdi,Alberto,03/08/1987", ris.First());
        }
    }
}