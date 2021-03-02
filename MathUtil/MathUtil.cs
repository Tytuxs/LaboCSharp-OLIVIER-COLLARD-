using MaLibrairieForme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtil
{
    public class MathUtil
    {
        private int _surface;

        public int Surface
        {
            get { return _surface; }
            set { _surface = value; }
        }

        public MathUtil() : this(0)
        {

        }

        public MathUtil(int val)
        {
            _surface = val;
        }

        public int CalculSurface(Carre c)
        {
            return (c.Cote * c.Cote);
        }

        public int CalculSurface(Rectangle r)
        {
            return (r.Largeur * r.Longueur);
        }

        public bool VerificationValeur(int min, int max, int val)
        {
            if (min <= val)
            {
                if (max >= val)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
    }
}
