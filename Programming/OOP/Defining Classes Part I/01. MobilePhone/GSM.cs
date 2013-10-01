using System;
using System.Collections.Generic;

namespace _01.MobilePhone
{
    internal class GSM
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;

        private static readonly GSM iPhone4S = new GSM("iPhone 4S", "Apple", 850.00M, null,
            new Battery("Apple", 300, 14, BatteryType.LiPoly), new Display(3.5, 16777216));

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

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value", "Model entry cannot be null");
                }

                if (value.Length < 2)
                {
                    throw new ArgumentException("Manufacturer entry must contain at least two characters");
                }

                this.manufacturer = value;
            }
        }

        public decimal? Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Price must be positive");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (value != null && value.Length < 3)
                {
                    throw new ArgumentException("Owner entry must contain at least three characters");
                }

                this.owner = value;
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }

        public static GSM IPhone4S
        {
            get { return iPhone4S; }
        }

        public List<Call> CallHistory { get; set; }

        public GSM(string model, string manufacturer)
            : this(model, manufacturer, null, null, null, null)
        {
        }

        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;

            this.CallHistory = new List<Call>();
        }

        public void AddCalls(params Call[] calls)
        {
            foreach (var call in calls)
            {
                this.CallHistory.Add(call);
            }
        }

        public bool RemoveCall(Call call)
        {
            return this.CallHistory.Remove(call);
        }

        public void ClearCallHistory()
        {
            this.CallHistory.Clear();

            Console.WriteLine("There are no entries in the call history");
        }

        public decimal CalculateTotalCallPrice(decimal pricePerMinute)
        {
            var result = 0M;

            foreach (var call in this.CallHistory)
            {
                result += (decimal) call.Duration.TotalMinutes*pricePerMinute;
            }

            return result;
        }

        public override string ToString()
        {
            return string.Format("Model: {0}, Manufacturer: {1}, Price: {2}, Owner: {3}, Battery: {4}, Display: {5}",
                this.Model, this.Manufacturer, (object) this.Price ?? "Unknown price", this.Owner ?? "Unknown owner",
                (object) this.Battery ?? "Unknown battery", (object) this.Display ?? "Unknown display");
        }
    }
}