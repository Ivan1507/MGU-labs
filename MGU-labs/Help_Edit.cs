using System;
using System.Collections.Generic;
using System.Text;

namespace MGU_labs
{
    class Help_Edit : IComparer<Edition>
    {
       int IComparer<Edition>.Compare(Edition x, Edition y)
        {
            return x.Num.CompareTo(y.Num);
        }
    }
}
