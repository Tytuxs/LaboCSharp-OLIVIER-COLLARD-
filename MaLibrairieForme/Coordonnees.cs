using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaLibrairieForme
{
    public class Coordonnees
    {
        private int _x;
        private int _y;

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }


        public Coordonnees() : this(0, 0)
        {

        }

        public Coordonnees(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            return "Coordonnées : (" + _x + "," + _y + ")";
        }
    }
}

