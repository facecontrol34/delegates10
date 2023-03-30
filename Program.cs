using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace andrewq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();

            garage.cars.Add(new Car("Buggati Veyron"));
            garage.cars.Add(new Car("Aston Martin Valkyrie"));
            garage.cars.Add(new Car("Koenigsegg Regera"));
            garage.cars.Add(new Car("McLaren Speedtail"));
            garage.cars.Add(new Car("SSC Tuatara"));

            Delegate washer = new Washer().Wash;

            washer(garage.cars[0]);
            washer(garage.cars[1]);
            washer(garage.cars[2]);
            washer(garage.cars[3]);
            washer(garage.cars[4]);


        }
        delegate void Delegate(Car car);
        class Car
        {
            public String carname { get; set; }

            public Car(string name)
            {
                this.carname = name;
            }
        }
         class Garage
        {
            public List<Car> cars { get; set; }

            public Garage()
            {
                cars = new List<Car>();
            }
        }
         class Washer
        {

            public void Wash(Car car)
            {
                Console.WriteLine("Автомобиль " + car.carname + " будет помыта");
            }
        }
    }
}
