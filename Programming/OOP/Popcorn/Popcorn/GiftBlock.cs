using System;
using System.Collections.Generic;

namespace Popcorn
{
    public class GiftBlock : Block
    {
        public const char Symbol = 'G';
        public GiftBlock(MatrixCoords topLeft)
            : base(topLeft)
        {
            this.body[0, 0] = GiftBlock.Symbol;
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
                List<Gift> gifts = new List<Gift>();

                gifts.Add(new Gift(topLeft));

                return gifts;
            }

            return base.ProduceObjects();

        }
    }
}
