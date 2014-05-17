using System;

namespace Popcorn
{
    public class Gift: MovingObject
    {
        public new const string CollisionGroupString = "gift";

        public const char Symbol = '$'; 

        public Gift(MatrixCoords topLeft)
            : base(topLeft, new char[,]{{Symbol}}, new MatrixCoords(1, 0))
        {
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == Racket.CollisionGroupString;
        }

        public override string GetCollisionGroupString()
        {
            return CollisionGroupString;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
            this.ProduceObjects();
        }

    }
}
