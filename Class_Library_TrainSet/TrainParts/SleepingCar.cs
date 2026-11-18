using Class_Library_TrainSet.People;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library_TrainSet.TrainParts
{
    public class SleepingCar:PassengerCarriage
    {
        public class SleepingCarriage : PassengerCarriage
        {
            public List<Conductor> Conductors { get; } =
                new List<Conductor>();

            public SleepingCarriage()
            {
            }

            public SleepingCarriage(
                int length,
                int emptyWeight,
                int seatsCount)
                : base(length, emptyWeight, seatsCount)
            {
            }

            public void AddConductor(Conductor conductor)
            {
                Conductors.Add(conductor);
            }

            public override string ToString()
            {
                return $"{base.ToString()}, Conductors :: {Conductors.Count}";
            }
        }
    }
}
