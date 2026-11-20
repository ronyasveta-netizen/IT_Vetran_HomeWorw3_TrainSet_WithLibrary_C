using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library_TrainSet.TrainParts
{
    public class IndustrialBulkCarriage: CargoCarriage
    {
        private int cargoWeight;
        public int CargoWeight
        { 
            get => cargoWeight;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Cargo weight cannot be negative");

                if (value > CarryingCapacity)
                {
                    throw new ArgumentException("The weight of the cargo is too great for this wagon");
                }

                cargoWeight = value;
            }
        }

        public IndustrialBulkCarriage(
            int length,
            int emptyWeight,
            int carryingCapacity,
            int cargoWeight)
            : base(length, emptyWeight, carryingCapacity)
        { 
            CargoWeight = cargoWeight;
        }

        public override string ToString()
        {
            return $"{base.ToString()} , WeightCargo = {CargoWeight} kg";
        }


    }
}
