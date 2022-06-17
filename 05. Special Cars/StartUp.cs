using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{

    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> allTires = new List<Tire[]>();
            string nextTireInfo = Console.ReadLine();
            List<double> averageSum= new List<double>();
            while (nextTireInfo != "No more tires")
            {
                string[] info = nextTireInfo.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var tire = new Tire[]
                {
                   new Tire( int.Parse(info[0]), double.Parse(info[1])),
                   new Tire( int.Parse(info[2]), double.Parse(info[3])),
                   new Tire( int.Parse(info[4]), double.Parse(info[5])),
                   new Tire( int.Parse(info[6]), double.Parse(info[7])),
                };
                double averageSumPressure = (double.Parse(info[1]) + double.Parse(info[3]) + double.Parse(info[5]) + double.Parse(info[7]));
                averageSum.Add(averageSumPressure);
                allTires.Add(tire);
                nextTireInfo = Console.ReadLine();
            }

            List<Engine> allEngines = new List<Engine>();
            string nextEngineInfo = Console.ReadLine();

            while (nextEngineInfo != "Engines done")
            {
                string[] info = nextEngineInfo.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var engine = new Engine(int.Parse(info[0]), double.Parse(info[1]));
                allEngines.Add(engine);
                nextEngineInfo = Console.ReadLine();
            }

            List<Car> allCars = new List<Car>();
            string nextCarInfo = Console.ReadLine();

            while (nextCarInfo != "Show special")
            {
                string[] info = nextCarInfo.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string make = info[0];
                string model = info[1];
                int year = int.Parse(info[2]);
                double fuelQuantity = double.Parse(info[3]);
                double fuelConsumption = double.Parse(info[4]);
                Engine engine = allEngines[int.Parse(info[5])];
                Tire[] tire = allTires[int.Parse(info[6])];

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tire);
                allCars.Add(car);
                nextCarInfo = Console.ReadLine();
            }
            for (int i = 0; i < allCars.Count ; i++)
            {
                if (averageSum[i] >= 9 && averageSum[i] <= 10)
                {
                    if (allCars[i].Year >= 2007 && allCars[i].Engine.HorsePower >= 330)
                    {
                        allCars[i].Drive(20);
                        Console.WriteLine($"Make: {allCars[i].Make}\nModel: {allCars[i].Model}\nYear: {allCars[i].Year}\nHorsePowers: {allCars[i].Engine.HorsePower}\nFuelQuantity: {allCars[i].FuelQuantity}");
                    }
                    
                }
            }
            
            
        }
    }


    class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }
        public Car(string make, string model, int year) : this()
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;

        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires) : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;

        }

        public string Make
        {
            get
            {
                return this.make;
            }
            set
            {
                this.make = value;
            }
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public int Year
        {
            get
            {
                return this.year;
            }
            set
            {
                this.year = value;
            }
        }
        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }
            set
            {
                this.fuelQuantity = value;
            }
        }
        public double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            set
            {
                this.fuelConsumption = value;
            }
        }

        public Engine Engine { get { return this.engine; } set { this.engine = value; } }
        public Tire[] Tires { get { return this.tires; } set { this.tires = value; } }

        public void Drive(double distance)
        {
            double result = fuelQuantity - distance * fuelConsumption;
            if (result > 0)
            {
                fuelQuantity = result;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.fuelQuantity:f2}";
        }
    }

    class Engine
    {
        private int horsePower;
        private double cubicCapacity;

        public Engine(int horsePower, double cubicCapacity)
        {
            HorsePower = horsePower;
            CubicCapacity = cubicCapacity;
        }

        public int HorsePower
        {
            get
            {
                return this.horsePower;
            }
            set
            {
                this.horsePower = value;
            }
        }
        public double CubicCapacity
        {
            get
            {
                return this.cubicCapacity;
            }
            set
            {
                this.cubicCapacity = value;
            }
        }
    }

    class Tire
    {
        public int year;
        public double pressure;

        public Tire(int year, double pressure)
        {
            Year = year;
            Pressure = pressure;
        }

        public int Year
        {
            get
            {
                return this.year;
            }
            set
            {
                this.year = value;
            }
        }
        public double Pressure
        {
            get
            {
                return this.pressure;
            }
            set
            {
                this.pressure = value;
            }
        }
    }
}
