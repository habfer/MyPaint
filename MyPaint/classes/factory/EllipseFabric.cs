using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    class EllipseFabric: Fabric
    {
        public override Shape Create()
        {
            return new Ellipse();
        }
    }
}
