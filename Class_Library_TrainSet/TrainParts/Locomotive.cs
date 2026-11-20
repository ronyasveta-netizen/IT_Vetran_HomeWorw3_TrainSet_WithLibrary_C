using Class_Library_TrainSet.Engines;
using Class_Library_TrainSet.People;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library_TrainSet.TrainParts
{
    public class Locomotive: TrainPart
    {
        public Driver Driver { get; set; }

        public Engine Engine { get; set; }


        
        public Locomotive(
            int length,
            Driver driver,
            Engine engine)
            : base(length)
        {
            if (driver == null)
                throw new ArgumentNullException(nameof(driver));

            if (engine == null)
                throw new ArgumentNullException(nameof(engine));

            Driver = driver;
            Engine = engine;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Driver :: {Driver}, Engine :: {Engine}";
        }
    }
}
