using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library_TrainSet.Engines
{
    public class ElectricEngine : Engine // Електродвигун наслідується від двигун
    {
        public int Voltage { get; set; }  // автовластивість  ( компілятор сам створить приховане поле) 
        public ElectricEngine() { } // конструктор без параметрів
        public ElectricEngine(int power, int voltage) // параматизований конструктор  використовує базовий
            : base(power)
        {
            Voltage = voltage;
        }
        public override string ToString() // перевизначення тустрінг з використанням базового  
        {
            return $"{base.ToString()}, Voltage:: {Voltage} V";
        }

    }
}
