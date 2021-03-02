using MaLibrairieForme;
using System;
using System.Collections.Generic;


namespace Labo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenu !");
            Console.WriteLine();


            Coordonnees c1 = new Coordonnees(5, 10);
            Coordonnees c2 = new Coordonnees(3, 4);

            Carre carre1 = new Carre(5, new Coordonnees(1, 1));
            Carre carredefaut = new Carre();
            Carre carre2 = new Carre(6, new Coordonnees(3, 3));
            Carre carre3 = new Carre(7, new Coordonnees(5, 5));
            Carre carre4 = new Carre(8, new Coordonnees(7, 7));

            Cercle cercle1 = new Cercle(8, c1);
            Cercle cercledefaut = new Cercle();

            Rectangle rectangle1 = new Rectangle(15, 20, c2);
            Rectangle rectangledefaut = new Rectangle();

            /*carre1.Affiche();
            carredefaut.Affiche();
            cercle1.Affiche();
            cercledefaut.Affiche();
            rectangle1.Affiche();
            rectangledefaut.Affiche();*/

            List<Forme> ListeForme = new List<Forme>();
            ListeForme.Add(carre1);
            ListeForme.Add(carredefaut);
            ListeForme.Add(cercle1);
            ListeForme.Add(cercledefaut);
            ListeForme.Add(rectangle1);
            ListeForme.Add(rectangledefaut);

            Console.WriteLine("Ma liste de Forme");
            Console.WriteLine("Appuyer sur une touche pour lancer la liste");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("liste :");

            foreach (Forme it in ListeForme)
            {
                it.Affiche();
            }

            Console.WriteLine();
            Console.WriteLine("Appuyer sur une touche pour lancer la liste implementant ISommet");
            Console.ReadKey();
            Console.WriteLine();

            foreach (Forme it in ListeForme)
            {
                if (it is ISommets)
                    it.Affiche();
            }

            Console.WriteLine();
            Console.WriteLine("Appuyer sur une touche pour lancer la liste n'implementant pas ISommet");
            Console.ReadKey();
            Console.WriteLine();

            foreach (Forme it in ListeForme)
            {
                int compteur = 0;
                if (it is ISommets)
                    compteur++;
                else
                    it.Affiche();
            }

            Console.WriteLine();


            List<Carre> ListeCarre = new List<Carre>();
            ListeCarre.Add(carredefaut);
            ListeCarre.Add(carre4);
            ListeCarre.Add(carre2);
            ListeCarre.Add(carre3);
            ListeCarre.Add(carre1);

            Console.WriteLine("Appuyer sur une touche pour lancer la liste de carres non-trie");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("liste de carre :");

            foreach (Carre it in ListeCarre)
            {
                it.Affiche();
            }

            Console.WriteLine();

            //trié
            Console.WriteLine("Appuyer sur une touche pour lancer la liste de carres trie");
            Console.ReadKey();
            Console.WriteLine();
            ListeCarre.Sort();
            foreach (Carre it in ListeCarre)
            {
                it.Affiche();
            }

            Console.WriteLine();

            //trier par ordre croissant des abscisses de position des Formes
            FormeAbscisseComparer f1 = new FormeAbscisseComparer();

            List<Forme> ListeForme2 = new List<Forme>();
            ListeForme2.Add(carre1);
            ListeForme2.Add(carredefaut);
            ListeForme2.Add(cercle1);
            ListeForme2.Add(cercledefaut);
            ListeForme2.Add(rectangle1);
            ListeForme2.Add(rectangledefaut);

            ListeForme2.Sort(f1);

            Console.WriteLine("Appuyer sur une touche pour lancer la liste de forme trie sur l'abscisse");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("ListeForme2 :");

            foreach (Forme it in ListeForme2)
            {
                it.Affiche();
            }

            Console.WriteLine();

            //ajout de 2 carres
            Carre carredefaut2 = new Carre();
            Carre carrecotedefaut = new Carre(0, new Coordonnees(2, 2));

            ListeCarre.Add(carredefaut2);
            ListeCarre.Add(carrecotedefaut);

            List<Carre> ListeCarreDefaut = new List<Carre>();

            ListeCarreDefaut = ListeCarre.FindAll(x => x.Cote == 0);

            Console.WriteLine("Appuyer sur une touche pour lancer la liste de carre par defaut");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("ListeCarreDefaut :");

            foreach (Carre it in ListeCarreDefaut)
            {
                it.Affiche();
            }

            Console.WriteLine();

            Console.WriteLine("Appuyer sur une touche pour lancer la liste de Forme");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Liste qui contient un point passe en parametre :");



            //trier liste d'objets Forme sur la surface


            Console.WriteLine();
            Console.WriteLine("Appuyer sur une touche pour quitter");
            Console.ReadKey();
        }
    }
}
