using System;

namespace _01.MobilePhone
{
    public class Call
    {
        private DateTime date;
        private string dialedPhone;
        private TimeSpan duration;

        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public string DialedPhone
        {
            get { return this.dialedPhone; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                if (value.Length < 6)
                {
                    throw new ArgumentException("The dialed phone must contain at least six numbers");
                }

                this.dialedPhone = value;
            }
        }

        public TimeSpan Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

        public Call(DateTime date, string dialedPhone, TimeSpan duration)
        {
            this.Date = date;
            this.DialedPhone = dialedPhone;
            this.Duration = duration;
        }

        public override string ToString()
        {
            return string.Format("Date: {0}, DialedPhone: {1}, Duration: {2}",
                this.Date, this.DialedPhone, this.Duration);
        }
    }
}