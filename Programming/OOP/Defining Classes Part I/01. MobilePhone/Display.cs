using System;

namespace _01.MobilePhone
{
    public class Display
    {
        private double? sizeInInches;
        private uint? numberOfColors;

        public double? SizeInInches
        {
            get { return this.sizeInInches; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Display size must be a positive number");
                }

                this.sizeInInches = value;
            }
        }

        public uint? NumberOfColors
        {
            get { return this.numberOfColors; }
            set { this.numberOfColors = value; }
        }

        public Display()
            : this(null, null)
        {
        }

        public Display(double? sizeInInchesInInches, uint? numberOfColors)
        {
            this.SizeInInches = sizeInInchesInInches;
            this.NumberOfColors = numberOfColors;
        }

        public override string ToString()
        {
            return string.Format("SizeInInches: {0}, NumberOfColors: {1}",
                (object) this.SizeInInches ?? "Unknown size", (object) this.NumberOfColors ?? "Unknown number of colors");
        }
    }
}