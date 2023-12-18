using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Car
    {
        public int CarID;
        public string Model;
        public string Brand;


        public Car(string brand, string model, int id)
        {
            Brand = brand;
            Model = model;
            CarID = id;
        }
    }
}
