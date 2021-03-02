using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MaLibrairieForme
{
    public abstract class Forme : IEstDans
    {
        protected Coordonnees _coord;

        public Coordonnees Coord
        {
            get { return _coord; }
            set { _coord = value; }
        }

        public Forme() : this(new Coordonnees())
        {

        }

        public Forme(Coordonnees coord)
        {
            _coord = new Coordonnees(coord.X, coord.Y);
        }

        public abstract void Affiche();

        public abstract bool CoordonneesEstDans(Coordonnees p);
    }
}
