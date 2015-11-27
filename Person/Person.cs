using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        private string name;
        private int age;
        private string email;
 
        public Person(string name, int age)
            :this(name, age, null)
        {

        }
        public Person(string name, int age, string email = null)
        {
            this.name = name;
            this.Age = age;
            this.Email = email;
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
        public int Age 
        {
            get { return this.age; }
            set
            {
                if (value > 1 && value < 100)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The age must be in range [1...100]");
                }
               
            }
        }
        public string Email 
        {
            get { return this.email; }
            set
            {
                if (value == null || value.Contains("@"))
                {
                    this.email = value;
                }
                else
                {
                    throw new ArgumentException("Email is not valid");
                }
            } 
        }

        public override string ToString()
        {
           
            if (this.Email != null)
            {
              return string.Format("Name: {0}\nAge: {1}\nEmail: {2}" , this.name , this.age , this.email);
            }
            else
            {
               return string.Format("Name: {0}\nAge: {1}", this.name, this.age);
            }

           
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Age: ");
            int age =int.Parse(Console.ReadLine());
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            Person person = new Person(name, age, email);
            Console.WriteLine(person);

        }
    }
}
