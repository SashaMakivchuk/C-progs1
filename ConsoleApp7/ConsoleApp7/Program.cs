using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp7.Worker;

namespace ConsoleApp7
{
     public struct Workers
    {
        public string Name;
        public string WorkPlace;
        public int Experience;
        public Adress Adress;


       public void Display()
        {
            Console.WriteLine($"Name: {Name}\nWorkPlace: {WorkPlace}\nExperience: {Experience}");
        }
    
    }
    public struct Adress
    {
        public string Street;
        public string City;
        public string PostalCode;
        public int BuildingNumber;

        
         
    }

    class Program
    {
        static void Main(string[] args)
        {
            Workers worker1 = new Workers();
           
            worker1.Name = "Name";
            worker1.WorkPlace = "Workplace";
            worker1.Experience = 1;
            worker1.Adress.Street = "street";
            worker1.Adress.City = "City";
            worker1.Adress.PostalCode = "12345";
            worker1.Adress.BuildingNumber = 1;

            Workers worker2 = new Workers();
            worker2.Name = "Name2";
            worker2.WorkPlace = "Workplace2";
            worker2.Experience = 11;
            worker2.Adress.Street = "street2";
            worker2.Adress.City = "City2";
            worker2.Adress.PostalCode = "123451";
            worker2.Adress.BuildingNumber = 11;

            worker1.Display();
            Workers[] Emploeers = new Workers[10];
            Emploeers[0] = worker1;
            Emploeers[1] = worker2;

            for (int i = 0; i < Emploeers.Length; i++)
            {
                Emploeers[i].Display();
            }
            Console.ReadLine();
        }
    }
}
