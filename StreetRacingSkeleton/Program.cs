using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StreetRacing
{
    public class StartUp
    {
        public class Car
        {

            public Car(string make, string model, string licenseplate, int horsepower, double weight)
            {
                this.Make = make;
                this.Model = model;
                this.LicensePlate = licenseplate;
                this.HorsePower = horsepower;
                this.Weight = weight;
            }

            public string Make { get; set; }

            public string Model { get; set; }

            public string LicensePlate { get; set; }

            public int HorsePower { get; set; }

            public double Weight { get; set; }

            public override string ToString()
            {
                return $"Make: {Make}\nModel: {Model}\nLicense Plate: {LicensePlate}\nHorse power: {HorsePower}\nWeight: {Weight}";
            }
        }

        public class Race
        {
            private List<Car> cars = new List<Car>();
            public Race(string name, string type, int laps, int capacity, int maxhorsepower)
            {
                this.Name = name;
                this.Type = type;
                this.Laps = laps;
                this.Capacity = capacity;
                this.MaxHorsePower = maxhorsepower;

            }

            public string Name { get; set; }
            public string Type { get; set; }
            public int Laps { get; set; }
            public int Capacity { get; set; }

            public int MaxHorsePower { get; set; }

            public int Count => cars.Count;
            public void Add(Car car)
            {
                var isExist = cars.FirstOrDefault(c => c.LicensePlate == car.LicensePlate);

                if (isExist == null && Capacity > Count && car.HorsePower <= MaxHorsePower)
                {
                    cars.Add(car);
                }
            }

            public bool Remove(string licenseplate)
            {
                var isExist = cars.FirstOrDefault(c => c.LicensePlate == licenseplate);
                if (isExist != null)
                {
                    cars.Remove(isExist);
                    return true;
                }
                return false;
            }

            public Car FindCar(string licenseplate)
            {
                return cars.FirstOrDefault(c => c.LicensePlate == licenseplate);
            }

            public Car GetMostPowerfullCar()
            {
                return cars.OrderByDescending(c => c.HorsePower).FirstOrDefault();
            }

            public string Report()
            {
                var result = new StringBuilder();

                result.AppendLine($"Race: {Name} - Type: {Type} (Laps: {Laps})");

                foreach (var item in cars)
                {
                    result.AppendLine(item.ToString());
                }

                return result.ToString().TrimEnd();
            }

        }


        static void Main(string[] args)
        {
            Race race = new Race("RockPort race", "Sprint", 1, 4, 150);
            Car car = new Car("BMW", "320ci", "NFS2005", 150, 1450);

            System.Console.WriteLine(car.ToString());

            race.Add(car);

            System.Console.WriteLine(race.Remove("NFS2005"));

            Car carOne = new Car("BMW", "320cd", "NFS2007", 150, 1350);
            Car carTwo = new Car("Audi", "A3", "NFS2004", 131, 1300);

            race.Add(carOne);
            race.Add(carTwo);

            Console.WriteLine(race.GetMostPowerfullCar());

            Console.WriteLine(race.Report());

        }
    }
}
