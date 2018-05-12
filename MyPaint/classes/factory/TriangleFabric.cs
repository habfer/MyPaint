using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    class TriangleFabric: Fabric
    {
        public override Shape Create()
        {
            return new Triangle();
        }
    }
}
