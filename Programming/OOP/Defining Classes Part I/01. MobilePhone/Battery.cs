using System;

namespace _01.MobilePhone
{
    public class Battery
    {
        private string model;
        private decimal? hoursIdle;
        private decimal? hoursTalk;
        private BatteryType type;

        public string Model
        {
            get { return this.model; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value", "Model entry cannot be null");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentException("Model entry must contain at least three characters");
                }

                this.model = value;
            }
        }

        public decimal? HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Hours idle value cannot be less than zero");
                }

                this.hoursIdle = value;
            }
        }

        public decimal? HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Hours talk value cannot be less than zero");
                }

                this.hoursTalk = value;
            }
        }

        public BatteryType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public Battery(string model)
            : this(model, null, null, BatteryType.Unknown)
        {
        }

        public Battery(string model, decimal? hoursIdle, decimal? hoursTalk, BatteryType type)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.Type = type;
        }

        public override string ToString()
        {
            return string.Format("Model: {0}, HoursIdle: {1}, HoursTalk: {2}, BatteryType: {3}",
                this.Model, (object) this.HoursIdle ?? "Unknown idle hours",
                (object) this.HoursTalk ?? "Unknown hours talk", this.type);
        }
    }
}