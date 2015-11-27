using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class LaptopShop
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Laptop model: ");
            string model = Console.ReadLine();
            Console.WriteLine("Manufacturer: ");
            string manifacturer = Console.ReadLine();
            Console.WriteLine("Processor: ");
            string processor = Console.ReadLine();
            Console.WriteLine("RAM: ");
            string ram = Console.ReadLine();
            Console.WriteLine("Graphic card: ");
            string card = Console.ReadLine();
            Console.WriteLine("HDD: ");
            string hdd = Console.ReadLine();
            Console.WriteLine("Screen: ");
            string screen = Console.ReadLine();
            Console.WriteLine("Battery type: ");
            string batType = Console.ReadLine();
            Console.WriteLine("Battery life: ");
            double batLife = double.Parse(Console.ReadLine());
            Battery battery = new Battery(batType, batLife);
            Console.WriteLine("Price: ");
            decimal price = decimal.Parse(Console.ReadLine());
            Laptop laptop = new Laptop(model, manifacturer, processor, ram, card, hdd, screen, battery, price);
            Console.WriteLine(laptop);
            Console.WriteLine(battery);
        }
    }
}
