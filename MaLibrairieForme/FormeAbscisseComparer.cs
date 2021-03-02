﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaLibrairieForme
{
    public class FormeAbscisseComparer : IComparer<Forme>
    {
        public int Compare(Forme x, Forme y)
        {
            return x.Coord.X.CompareTo(y.Coord.X);
        }
    }
}
