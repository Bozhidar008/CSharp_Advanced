using System;

namespace CarManufacturer
{

    public class StartUp
    {
        static void Main(string[] args)
        {
            var tires = new Tire[4]
            {
               new Tire(1,2.5),
               new Tire(1,2.1),
               new Tire(1,0.5),
               new Tire(1,2.3),
            };

            var engine = new Engine(560, 6300);
            var car = new Car("lamborghini", "Urus", 2010, 250, 9, engine, tires);
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

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires ): this(make, model, year, fuelQuantity, fuelConsumption)
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
