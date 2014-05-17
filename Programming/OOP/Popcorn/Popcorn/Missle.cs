using System;

namespace Popcorn
{
    class Missle: MovingObject
    {
        public Missle(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, new char[,] { { '^' } }, speed)
        {
        }

        public override void Update()
        {
            IsDestroyed = true;
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == Block.CollisionGroupString;
        }
    }
}
