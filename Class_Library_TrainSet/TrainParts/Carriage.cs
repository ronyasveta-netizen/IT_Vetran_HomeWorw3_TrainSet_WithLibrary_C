using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library_TrainSet.TrainParts
{
    public abstract class Carriage: TrainPart
    {
        private int emptyWeight;

        public int EmptyWeight
        {
            get => emptyWeight;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Weight must be positive");

                emptyWeight = value;
            }
        }

        protected Carriage()
        {
        }

        protected Carriage(int length, int emptyWeight)
            : base(length)
        {
            EmptyWeight = emptyWeight;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Empty weight :: {EmptyWeight}";
        }
    }
}
