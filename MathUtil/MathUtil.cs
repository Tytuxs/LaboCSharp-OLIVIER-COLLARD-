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

        public static double SurfaceCercle(int rayon)
        {
            return Math.Pow(rayon, 2) * Math.PI;
        }

        public static double SurfaceCarre(int cote)
        {
            return Math.Pow(cote, 2);
        }

        public static double SurfaceRectangle(int largeur, int longueur)
        {
            return largeur*longueur;
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
