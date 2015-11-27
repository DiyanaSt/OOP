using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicCard;
        private string hdd;
        private string screen;
        private Battery battery;
        private decimal price;

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }
        public Laptop(string model, string manufacturer, string processor, string ram, string graphicCard, string hdd, string screen, Battery battery, decimal price)
            :this (model, price)
        {
            this.Manifacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicCard = graphicCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.battery = Battery;
        }

        public string Model 
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Laptop model is mandatory. It cannot be empty");
                }
                this.model = value;
            }
        }
        public string Manifacturer 
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }
        public string Processor 
        {
            get { return this.processor; }
            set { this.processor = value; }
        }
        public string Ram 
        {
            get { return this.ram; }
            set { this.ram = value; }
        }
        public string GraphicCard 
        {
            get { return this.graphicCard; }
            set { this.graphicCard = value; }
        }
        public string Hdd 
        {
            get { return this.hdd; }
            set { this.hdd = value; }
        }
        public string Screen 
        {
            get { return this.screen; }
            set { this.screen = value; }
        }
        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }
        public decimal Price 
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Laptop model: " + this.model);
            if (this.Manifacturer != null)
            {
                result.AppendLine("Manifacturer: " + this.manufacturer);
            }
            if (this.Processor != null)
            {
                result.AppendLine("Processor: " + this.processor);
            }
            if (this.Ram != null)
            {
                result.AppendLine("RAM: " + this.ram);
            }
            if (this.GraphicCard != null)
            {
                result.AppendLine("Graphic Card: " + this.graphicCard);
            }
            if (this.Hdd != null)
            {
                result.AppendLine("HDD: " + this.hdd);
            }
            if (this.Screen != null)
            {
                result.AppendLine("Screen: " + this.screen);
            }
            if (this.Battery != null)
            {
                result.AppendLine(this.Battery.ToString());
               
            }
            result.AppendLine("Price: " + this.price);
              return result.ToString();
        }

    }
}
