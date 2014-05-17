using System;

namespace Popcorn
{
    public class TrailObject : GameObject
    {
        public const char Symbol = '_';
        public uint lifetime { get;  protected set; }

        public TrailObject(MatrixCoords topLeft, uint lifetime)
            : base(topLeft, new char[,] { { Symbol } })
        {
            this.lifetime = lifetime;
        }

        public override void Update()
        {
            if (this.lifetime == 1)
            {
                IsDestroyed = true;
            }
            else
            {
                this.lifetime--;
            }
        }
    }
}
