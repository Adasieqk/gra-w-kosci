using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfKosc;

namespace KoscTesty
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestZakresuRzutu()
        {
            Kosc k = new Kosc();
            for (int i = 0; i < 100; i++)
            {
                k.Rzut();
                Assert.IsTrue(k.LiczbaOczek >= 1 && k.LiczbaOczek <= 6);
            }
        }

        [TestMethod]
        public void TestBlokadyKosci()
        {
            Kosc k = new Kosc(3);
            k.Blokuj();
            int wartoscPrzed = k.LiczbaOczek;
            k.Rzut();
            Assert.AreEqual(wartoscPrzed, k.LiczbaOczek);
        }
    }
}