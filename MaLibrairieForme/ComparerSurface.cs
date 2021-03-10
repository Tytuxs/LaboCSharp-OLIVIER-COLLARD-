using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaLibrairieForme
{
    public class ComparerSurface : IComparer<Forme>
    {
        public int Compare(Forme x, Forme y)
        {
            return x.Surface().CompareTo(y.Surface());
        }
    }
}
