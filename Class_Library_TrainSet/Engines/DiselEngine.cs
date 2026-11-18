using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library_TrainSet.Engines
{
    public class DiselEngine : Engine // Дизельний двигун наслідується від двигун
    {
        public int CylinderCount { get; set; }
        public DiselEngine() { }
        public DiselEngine(int power, int cylinderCount)
            : base(power)
        {
            CylinderCount = cylinderCount;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, CountCylinders: {CylinderCount} ";
        }
    }
}
