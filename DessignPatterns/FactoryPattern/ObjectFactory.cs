using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class ObjectFactory
    {
        public static IBuisnessThingy Create()
        {
            var boolean = true;
            if (boolean)
                return new ConcreteBuisnessObject("foo");
            else
                return new SeconConcrateBuisnessObject();
        }

    }

}
