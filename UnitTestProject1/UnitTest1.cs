using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaLibrairieForme;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        /*public void TestConstructeurCarre()
        {
            Carre carre1 = new Carre(5, new Coordonnees(1, 1));
            if (carre1.Cote != 5)
                Assert.Fail("erreur creation cote carre");
            carre1.Affiche();
        }*/

        /****correct ?***/
        
        public void TestTriageListe()
        {
            Carre carre1 = new Carre(5, new Coordonnees(1, 1));
            Carre carredefaut = new Carre();
            Carre carre2 = new Carre(6, new Coordonnees(3, 3));
            Carre carre3 = new Carre(7, new Coordonnees(5, 5));
            Carre carre4 = new Carre(8, new Coordonnees(7, 7));

            List<Carre> ListeCarre = new List<Carre>();
            ListeCarre.Add(carredefaut);
            ListeCarre.Add(carre4);
            ListeCarre.Add(carre2);
            ListeCarre.Add(carre3);
            ListeCarre.Add(carre1);

            Console.WriteLine("non-trie");
         
            //non trie
            foreach (Carre it in ListeCarre)
            {
                it.Affiche();
            }

            //trie
            Console.WriteLine("trie");

            ListeCarre.Sort();
            foreach (Carre it in ListeCarre)
            {
                it.Affiche();
            }

            Console.WriteLine();
            Console.WriteLine();

        }
        
    }
}
