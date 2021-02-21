using System;

namespace ParkingGarage
{
    public class Customers
    {
        public double price;
        public int hours;
        public string licenseplate;

        public Customers(int _hours, string _plate)
        {
            price = 2;
            hours = _hours;
            licenseplate = _plate;
        }

        public double calculateCharges()
        {
            double res = 2;
            if(hours > 3)
            {
                res += (hours-3)*0.5;
                if(res >10)
                {
                    res = 10;
                }
                price = res;
            }
            return res;
        }
    }
}