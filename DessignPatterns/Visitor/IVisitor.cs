﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    /// <summary>

    /// The 'Visitor' interface

    /// </summary>

    interface IVisitor

    {
        void Visit(Element element);
    }
}
