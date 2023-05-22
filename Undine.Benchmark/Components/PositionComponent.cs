using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undine.Benchmark.Components
{
    public struct PositionComponent
    {
        public float x;
        public float y;

        public override string ToString()
        {
            return y.ToString();
        }
    }
}