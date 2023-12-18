using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    class Garage
    {
        public Car TilføjBil(string brand, string model, int id)
        {
            Car car = new Car(brand, model, id);
            return car;
        }
        public StringBuilder UdlæsBil(List<Car> cars)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Car car in cars)
            {
                sb.AppendLine($"ID: {car.CarID} - Mærke: {car.Brand} - Model: {car.Model}" + Environment.NewLine);
            }
            return sb;
        }
        public string FindBil(int id, List<Car> cars)
        {
            Car car = cars.Where(i => i.CarID == id).FirstOrDefault();
            return $"ID: {car.CarID} - Brand: {car.Brand} - Model: {car.Model}";
        }
        public string SletBil(int id, List<Car> cars)
        {
            Car car = cars.Where(i => i.CarID == id).FirstOrDefault();
            string returnValue = $"Slettede bil:\n ID: {car.CarID}\nMærke: {car.Brand}\nModel: {car.Model}";
            cars.Remove(car);
            return returnValue;
        }
    }
}
