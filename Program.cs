namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
                new Car {Make = "Oldsmobile", Model = "Cutlas Supreme", VIN = "E5", Year = 2006},
                new Car { Make = "Nissan", Model = "Escape", VIN = "f2", Year = 2016 },
                new Car { Make = "BMW", Model = "XZY", VIN = "f9", Year = 2002},
                new Car { Make = "Fusca", Model = "Travel", VIN = "f7", Year = 1998 },
                new Car { Make = "Chevette", Model = "ABC", VIN = "f3", Year = 2015 },
                new Car { Make = "Kadett", Model = "OffRoad", VIN = "f4", Year = 1950 }
            };

            //LINK Query
            /*
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.VIN == "f9"
                       select car;

            foreach (var car in bmws)
            {
                Console.WriteLine("{0} {1}", car.Make, car.VIN);

            }*/
            /*
            var orderedCars = from car in myCars
                              orderby car.Make ascending
                              select car;
            */

            //LINK Method
            // var bmws = myCars.Where(p => p.Make == "Fusca");

            /*var orderedCars = myCars.OrderByDescending(p => p.Make);

            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1}", car.Make, car.VIN);

            }
            */
            //Console.WriteLine(myCars.TrueForAll(p => p.Year > 1940));
            //Console.WriteLine(myCars.Sum(p=> p.Year));

            Console.WriteLine(myCars.GetType());
            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }

}