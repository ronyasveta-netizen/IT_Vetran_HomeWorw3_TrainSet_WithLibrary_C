using Class_Library_TrainSet.Engines;
using Class_Library_TrainSet.Intheface;
using Class_Library_TrainSet.People;
using Class_Library_TrainSet.Train;
using Class_Library_TrainSet.TrainParts;
namespace IT_Vetran_HomeWorw3_TrainSet_WithLibrary_C

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Passenger passenger = new Passenger();
            Console.WriteLine(passenger);
            ElectricEngine engine = new ElectricEngine();
            Console.WriteLine(engine);
            Console.WriteLine();

            SleepingCarriage carriage = new SleepingCarriage(25, 40, 2); // створюємо пустий вагон 


            Passenger p1 = new Passenger("Ivan", "Rotko", 1, true, 1);// створюємо пасажирів 


            Passenger p2 = new Passenger("Madyar", "Browdy", 2, true, 2);


            Attendant c1 = new Attendant("Anna", "Karenina", false); // створюєо провідника  


            carriage.AddPassenger(p1); // додаємо їх в вагон 
            carriage.AddPassenger(p2);

            carriage.AddConductor(c1);

            Console.WriteLine(carriage); // інформація про вагон 
            Console.WriteLine();
            foreach (Passenger p in carriage.Passengers) // інформація про пасажирів 
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();
            foreach (Attendant c in carriage.Attendants) // про провідника 
            {
                Console.WriteLine(c);
            }

            // -----------------------------------
            // Машиністи
            Driver driver1 = new Driver("Ivan", "Bogun", 10);

            Driver driver2 = new Driver("Oleg", "Knyaz", 15);

            // Двигуни
            DiselEngine dieselEngine = new DiselEngine(4000, 16);

            ElectricEngine electricEngine =new ElectricEngine(5000, 3000);

            // Локомотиви
            Locomotive locomotive1 = new Locomotive(20, driver1, dieselEngine);


            Locomotive locomotive2 = new Locomotive(22, driver2, electricEngine);

           // Вагони
            GeneralCarriage generalCarriage = new GeneralCarriage(25, 30000, 54);


            SleepingCarriage sleepingCarriage = new SleepingCarriage(27, 35000, 36);

            IndustrialBulkCarriage cargoCarriage = new IndustrialBulkCarriage(18, 25000, 60000, 45000);

            sleepingCarriage.AddPassenger(p1);
            sleepingCarriage.AddPassenger(p2);

            sleepingCarriage.AddConductor(c1);

            // Поїзд
            Train train = new Train(101);

            train.AddLocomotive(locomotive1);
            train.AddLocomotive(locomotive2);

            train.AddCarriage(generalCarriage);
            train.AddCarriage(sleepingCarriage);
            train.AddCarriage(cargoCarriage);

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine(train);

            Console.WriteLine();

            Console.WriteLine("Locomotives:");
            foreach (var locomotive in train.Locomotives)
            {
                Console.WriteLine(locomotive);
            }

            Console.WriteLine();

            Console.WriteLine("Carriages:");
            foreach (var carriageItem in train.Carriages)
            {
                Console.WriteLine(carriageItem);
            }

            c1.MakeCoffee();
            driver1.Accelerate();


        }
    }
}
