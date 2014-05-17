using System;
using System.Collections.Generic;

namespace Popcorn
{
    class MeteoriteBall : Ball
    {
        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed)
        {
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            var trail = new[]
            {
                new TrailObject(topLeft, 3),
            };

            return trail;
        }
    }
}
