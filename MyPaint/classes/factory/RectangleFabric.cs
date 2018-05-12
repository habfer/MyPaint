using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    class RectangleFabric: Fabric
    {
        public override Shape Create()
        {
            return new Rectangle();
        }
    }
}
