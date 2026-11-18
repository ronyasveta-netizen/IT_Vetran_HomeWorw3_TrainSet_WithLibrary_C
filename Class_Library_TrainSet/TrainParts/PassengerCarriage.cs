using Class_Library_TrainSet.People;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library_TrainSet.TrainParts
{
    
    public abstract class PassengerCarriage : Carriage
    {
        private int seatsCount;

        public int SeatsCount
        {
            get => seatsCount;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Seats count must be positive");

                seatsCount = value;
            }
        }

        public List<Passenger> Passengers { get; } =
            new List<Passenger>();

        protected PassengerCarriage()
        {
        }

        protected PassengerCarriage(
            int length,
            int emptyWeight,
            int seatsCount)
            : base(length, emptyWeight)
        {
            SeatsCount = seatsCount;
        }

        public void AddPassenger(Passenger passenger)
        {
            if (Passengers.Count >= SeatsCount)
                throw new Exception("No free seats");

            Passengers.Add(passenger);
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Seats count:: {SeatsCount}, Passengers:: {Passengers.Count}";
        }
    }
}

