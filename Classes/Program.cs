namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car bexCar = new Car();
            bexCar.Make = "Honda";
            bexCar.Model = "Civic";
            bexCar.Year = 2017;

            Car brettCar = new Car();
            brettCar.Make = "Nisson";
            brettCar.Model = "Optima";
            brettCar.Year = 2015;

            Car ianCar = new Car();
            ianCar.Make = "Volkswagen";
            ianCar.Model = "Jetta";
            ianCar.Year = 2009;

            var houseCars = new List<Car>() { bexCar, brettCar, ianCar };

            foreach(var residentCar in houseCars)
            {
                Console.WriteLine($"{residentCar.Make} {residentCar.Model} {residentCar.Year}");
            }
        }
    }
}
