using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class Battery
    {
        private string type;
        private double hours;

        public Battery(string type, double hours)
        {
            this.Type = type;
            this.Hours = hours;
        }

        public string Type 
        {
            get { return this.type; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Battery type cannot be empty");
                }
                this.type = value;
            } 
        }
        public double Hours 
        {
            get { return this.hours; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Battery life cannot be negative integer!");
                }
                this.hours = value;
            }
        }

        public override string ToString()
        {
            StringBuilder resultStr = new StringBuilder();
            if (this.Type != null)
            {
                resultStr.AppendLine("Battery type: " + this.type);
            }
            if (this.Hours > 0)
            {
                resultStr.AppendLine("Battery life: " + this.hours + "hours");
            }
            return resultStr.ToString();
        }
    }
}
