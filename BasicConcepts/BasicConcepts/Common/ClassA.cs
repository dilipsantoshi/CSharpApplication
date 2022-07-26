using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConcepts.Common
{
    class ClassA
    {
      public  int X = 0;
        public ClassA() : this(10)
        { }

        public ClassA(int pValue)
        {
            X = pValue;
        }
    }
}
