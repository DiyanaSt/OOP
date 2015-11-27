using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCatalog
{
    class PCCatalog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter computer name: ");
            string name = Console.ReadLine();
            Computer computer = new Computer(name, AddComponents());
            Console.WriteLine(computer.ToString());
            
           
        }

        static List<Component> AddComponents()
        {
            List<Component> components = new List<Component>();
            string check = null;
            do
            {
                Console.WriteLine("Enter component: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter details for the component: ");
                string details = Console.ReadLine();
                Console.WriteLine("Enter component price:");
                decimal price = decimal.Parse(Console.ReadLine());
                Component component = new Component(name, price, details);
                components.Add(component);
                Console.WriteLine("Would you like to enter another component? Yes\\No");
                check = Console.ReadLine();
            } while (check != "No" && check != "no" && check != "NO");

            return components;
        }
    }
}
