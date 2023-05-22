using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Undine.Benchmark.Components;
using Undine.Core;

namespace Undine.Benchmark.Systems
{
    public class AccelerationSystem : UnifiedSystem<VelocityComponent, AccelerationComponent>
    {
        public override void ProcessSingleEntity(int entityId, ref VelocityComponent a, ref AccelerationComponent b)
        {
            a.x += b.x;
            a.y += b.y;
        }
    }
}