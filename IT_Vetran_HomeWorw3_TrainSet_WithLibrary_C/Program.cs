using Class_Library_TrainSet.Engines;
using Class_Library_TrainSet.Intheface;
using Class_Library_TrainSet.People;
using Class_Library_TrainSet.TrainParts;
using static Class_Library_TrainSet.TrainParts.SleepingCar;
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


            Conductor c1 = new Conductor("Anna", "Karenina", false); // створюєо провідника  


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
            foreach (Conductor c in carriage.Conductors) // про провідника 
            {
                Console.WriteLine(c);
            }


        }
    }
}
