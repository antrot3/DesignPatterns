﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    /// <summary>

    /// The 'Aggregate' interface

    /// </summary>

    interface IAbstractCollection

    {
        Iterator CreateIterator();
    }
}
