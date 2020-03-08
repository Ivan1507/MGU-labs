using System;
using System.Collections.Generic;
using System.Text;

namespace MGU_labs
{
    class Mag_col_Comparer : IComparer<MagazineCollection>
    {
        int IComparer<MagazineCollection>.Compare(MagazineCollection x, MagazineCollection y)
        {
            return x.Tirzj.CompareTo(y.Tirzj);
        }
    }
}
