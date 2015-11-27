using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCatalog
{
    class Computer
    {
        private string name;
        private List<Component> components;
        private decimal price;

        public Computer(string name, List<Component> components)
        {
            this.Name = name;
            this.Price = PriceTotal(components);
            this.Components = components;
        }
        public string Name 
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }
        public List<Component> Components 
        { 
            get{return this.components;} 
            set
            {
                if (value== null )
                {
                    throw new ArgumentException("Components are mandatory");
                }
                this.components = value;
            } 
        }
        private decimal PriceTotal(List<Component> components)
        {
            decimal totalPrice = 0;
            foreach (Component component in components)
            {
                totalPrice += component.Price;
            }
            return totalPrice;
        }
        public decimal Price { get; set; }

        public override string ToString()
        {
            string result = string.Empty;
            result = "Computer name: " + this.name + "\n";
            foreach (Component component in components)
            {
                string comp = component.Name.ToString();
                result += "Component: " + comp + "\n";
            }

            string priceStr = string.Format("Price of all components: {0:C}", this.Price, CultureInfo.CreateSpecificCulture("bg-BG"));
            result += priceStr + "\n";
            return string.Format(result);
        }
    }
}
