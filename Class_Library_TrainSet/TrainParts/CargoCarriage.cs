using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library_TrainSet.TrainParts
{
    public abstract class CargoCarriage : Carriage
    {
        private int carryingCapacity;

        public int CarryingCapacity
        {
            get => carryingCapacity;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Carrying capacity must be positive");

                carryingCapacity = value;
            }
        }

        protected CargoCarriage() { }


        protected CargoCarriage(
            int length,
            int emptyWeight,
            int carryingCapacity)
            : base(length, emptyWeight)
        {
            CarryingCapacity = carryingCapacity;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Carrying capacity:: {CarryingCapacity} kg";
        }
    }
}
