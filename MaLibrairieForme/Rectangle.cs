using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaLibrairieForme
{
    public class Rectangle : Forme, ISommets
    {
        private int _largeur;
        private int _longueur;

        public Rectangle() : base()
        {
            _largeur = 0;
            _longueur = 0;
        }

        public Rectangle(int larg, int lon, Coordonnees f) : base(f)
        {
            _largeur = larg;
            _longueur = lon;
        }

        public int Largeur
        {
            get { return _largeur; }
            set { _largeur = value; }
        }

        public int Longueur
        {
            get { return _longueur; }
            set { _longueur = value; }
        }

        public override void Affiche()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return "Rectangle   (Coordonnées(x,y), largeur, longueur) : ((" + _coord.X + "," + _coord.Y + "), " + _largeur + ", " + _longueur + ")";
        }

        public override bool CoordonneesEstDans(Coordonnees p)
        {
            int XCoinSupGauche = _coord.X;
            int YCoinSupGauche = _coord.Y;
            int XCoinInfDroit = _coord.X + _longueur;
            int YCoinInfDroit = _coord.Y + _largeur;

            if (p.X <= XCoinInfDroit && p.X >= XCoinSupGauche)
            {
                if (p.Y <= YCoinInfDroit && p.Y >= YCoinSupGauche)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public int NbSommet()
        {
            return 4;
        }
    }
}
