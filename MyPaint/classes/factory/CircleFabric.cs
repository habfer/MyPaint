using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    class CircleFabric: Fabric
    {
        public override Shape Create()
        {
            return new Circle();
        }
    }
}
