using System;
using static MathUtil.MathUtil;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaLibrairieForme
{
    public class Cercle : Forme
    {
        private int _rayon;

        public int Rayon
        {
            get { return _rayon; }
            set { _rayon = value; }
        }

        public Cercle() : base()
        {
            _rayon = 0;
        }

        public Cercle(int R, Coordonnees coord) : base(coord)
        {
            _rayon = R;
        }

        public override void Affiche()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return "Cercle      (Coordonnées(x,y), rayon)             : ((" + _coord.X + "," + _coord.Y + "), " + _rayon + ")";
        }

        public override bool CoordonneesEstDans(Coordonnees p)
        {
            int XCentreCercle = _coord.X;
            int YCentreCercle = _coord.Y;
            int resultat;
            int R;

            resultat = (p.X - XCentreCercle) * (p.X - XCentreCercle) + (p.Y - YCentreCercle) * (p.Y - YCentreCercle); // formule (C : (X-Xcentre)² + (Y-Ycentre)² = R²)
            R = _rayon * _rayon;

            if (resultat <= R)
                return true;
            else
                return false;
        }

        public override double Surface()
        {
            return SurfaceCercle(Rayon);
        }
    }
}
