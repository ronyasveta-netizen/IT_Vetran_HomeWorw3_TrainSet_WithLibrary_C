using Class_Library_TrainSet.People;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library_TrainSet.TrainParts
{
    
    public class SleepingCarriage : PassengerCarriage
    {
        public List<Attendant> Attendants { get; } = new List<Attendant>();
        public SleepingCarriage() { }

        public SleepingCarriage(
            int length,
            int emptyWeight,
            int seatsCount)
            : base(length, emptyWeight, seatsCount) { }
        

        public void AddConductor(Attendant conductor)
        {
            Attendants.Add(conductor);
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Conductors :: {Attendants.Count}";
        }
    }
    
}
