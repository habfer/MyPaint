using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    class LineFabric: Fabric
    {
        public override Shape Create()
        {
            return new Line();
        }
    }
}
