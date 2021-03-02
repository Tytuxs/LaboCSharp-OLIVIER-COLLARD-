using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaLibrairieForme;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConstructeurCarre()
        {
            Carre carre1 = new Carre(5, new Coordonnees(1, 1));
            if (carre1.Cote != 5)
                Assert.Fail("erreur creation cote carre");
            carre1.Affiche();
        }

        /****correct ?***/
        /*
        public void TestMethod2(), etc ? 
        */
    }
}
