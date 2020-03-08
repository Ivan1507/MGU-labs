using System;
using System.Collections.Generic;
using System.Text;

namespace MGU_labs
{
    interface IRateAndCopy
    {
        double Rating { get; }
        object DeepCopy();
    }
}
