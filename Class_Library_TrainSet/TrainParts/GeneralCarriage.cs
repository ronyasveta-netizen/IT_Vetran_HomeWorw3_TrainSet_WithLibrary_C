using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library_TrainSet.TrainParts
{
    public class GeneralCarriage:PassengerCarriage
    {
        public GeneralCarriage() { }

        public GeneralCarriage(
            int length,
            int emptyWeight,
            int seatsCount)
            : base(length, emptyWeight, seatsCount) { }


        public override string ToString()
        {
            return $"General carriage, {base.ToString()}";
        }
    }
}
