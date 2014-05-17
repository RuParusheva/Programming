using System;

namespace Popcorn
{
    class ImpassableBlock : IndestructibleBlock
    {
        public new const string CollisionGroupString = "impassable block";

        public const char Symbol = 'X';

        public ImpassableBlock(MatrixCoords upperLeft)
            : base(upperLeft)
        {
            this.body[0, 0] = ImpassableBlock.Symbol;
        }

        public override string GetCollisionGroupString()
        {
            return ImpassableBlock.CollisionGroupString;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
        }
    }
}
