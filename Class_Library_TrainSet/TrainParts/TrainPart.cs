using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library_TrainSet.TrainParts
{
    public abstract class TrainPart
    {
        private int length;
        public int Length
        {
            get => length;

            set 
                { if(value <= 0)
                    throw new ArgumentException("Carriage length can be positive");

                  length = value;  

                }

        
        }
        public TrainPart() { }
        public TrainPart(int length)
        {
            Length = length;
        }

        public override string ToString()
        {
            return $"Carriage length :: {Length}";
        }
    }
}
