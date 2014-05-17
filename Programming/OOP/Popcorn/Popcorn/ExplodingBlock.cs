using System;
using System.Collections.Generic;

namespace Popcorn
{
    public class ExplodingBlock: Block
    {
        public const char Symbol = 'E'; 

        public ExplodingBlock(MatrixCoords topLeft)
            : base(topLeft)
        {
            this.body[0, 0] = ExplodingBlock.Symbol;
        }


        public override void RespondToCollision(CollisionData collisionData)
        {
            IsDestroyed = true;
            this.ProduceObjects();
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            if (IsDestroyed)
            {
                List<Missle> missles = new List<Missle>();

                for (int row = -1; row < 1; row++)
                {
                    for (int col = -1; col < 1; col++)
                    {
                        missles.Add(new Missle(TopLeft, new MatrixCoords(row, col)));
                    }
                }

                return missles;
            }

            return base.ProduceObjects();
        }
    }
}
