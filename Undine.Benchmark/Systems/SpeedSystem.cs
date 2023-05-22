using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Undine.Benchmark.Components;
using Undine.Core;

namespace Undine.Benchmark.Systems
{
    public class SpeedSystem : UnifiedSystem<PositionComponent, VelocityComponent>
    {
        public override void ProcessSingleEntity(int entityId, ref PositionComponent a, ref VelocityComponent b)
        {
            a.x += b.x;
            a.y += b.y;
        }
    }
}