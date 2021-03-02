using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ToString() correct ? et du coup Affiche() aussi ?

namespace MaLibrairieForme
{
    public class Carre : Forme, ISommets, IComparable<Carre>
    {
        private int _cote;

        public int Cote
        {
            get { return _cote; }
            set { _cote = value; }
        }

        public Carre() : base()
        {
            _cote = 0;
        }

        public Carre(int c, Coordonnees f) : base(f)
        {
            _cote = c;
        }

        public override void Affiche()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return "Carre       (Coordonnées(x,y), cote)              : ((" + _coord.X + "," + _coord.Y + "), " + _cote + ")";
        }

        public override bool CoordonneesEstDans(Coordonnees p)
        {
            int XCoinSupGauche = _coord.X;
            int YCoinSupGauche = _coord.Y;
            int XCoinInfDroit = _coord.X + _cote;
            int YCoinInfDroit = _coord.Y + _cote;

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

        public int CompareTo(Carre autre)
        {
            return this.Cote.CompareTo(autre.Cote);
        }


    }
}

