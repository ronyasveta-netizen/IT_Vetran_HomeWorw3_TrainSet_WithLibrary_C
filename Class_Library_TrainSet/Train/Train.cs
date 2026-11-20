using Class_Library_TrainSet.TrainParts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library_TrainSet.Train
{
    public class Train
    {
        private int trainNumber;

        public int TrainNumber
        {
            get => trainNumber;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Train number must be positive");

                trainNumber = value;
            }
        }
        public List<Locomotive> Locomotives { get; } = new List<Locomotive>();          
        public List<Carriage> Carriages { get; } = new List<Carriage>();

        public Train(int trainNumber) // порожній спочатку а потім наповнюємо
        {
            TrainNumber = trainNumber;
        }

        public void AddLocomotive(Locomotive locomotive)
        {
            if (locomotive == null)
                throw new ArgumentNullException(nameof(locomotive));

            Locomotives.Add(locomotive);
        }


        public void AddCarriage(Carriage carriage)
        {
            if (carriage == null)
                throw new ArgumentNullException(nameof(carriage));

            Carriages.Add(carriage);
        }


        public override string ToString()
        {
            return $"Train number :: {TrainNumber} :: " +
                   $"Locomotives  :: {Locomotives.Count} :: " +
                   $"Carriages    :: {Carriages.Count}";
        }
    }
}
