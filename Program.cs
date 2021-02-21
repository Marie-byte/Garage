using System;
using System.Collections.Generic;

namespace ParkingGarage
{
    class Program
    {

        static List<Customers> InitGarage()
        {
            List<Customers> garage = new List<Customers>();
            Customers cus1 = new Customers(6,"6LIK274");
            Customers cus2 = new Customers(2,"5TRJ244");
            Customers cus3 = new Customers(9,"7TYP290");
            Customers cus4 = new Customers(22,"2GAT123");
            Customers cus5 = new Customers(16,"3SAM153");
            Customers cus6 = new Customers(21,"7TRR812");
            garage.Add(cus1);
            garage.Add(cus2);
            garage.Add(cus3);
            garage.Add(cus4);
            garage.Add(cus5);
            garage.Add(cus6);
            return garage;
        }

        static void Hour(List<Customers> garage)
        {
            foreach(Customers customer in garage)
            {
                customer.hours++;
            }
        }

        static void ShowCharges(List<Customers> garage)
        {
            double sum = 0;
            foreach(Customers customer in garage)
            {
                Console.Write(customer.licenseplate+" : ");
                Console.WriteLine(customer.calculateCharges()+"€");
                sum+=customer.price;
            }
            Console.WriteLine("Sum : "+sum+"€");
        }
        static void Main(string[] args)
        {
            List<Customers> garage = InitGarage();
            ShowCharges(garage);
        }
    }
}
