using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library_TrainSet.Engines
{
    public abstract class Engine // абстрактний двигун
    {
        private int power = 0;  // приховане поле 
        public int Power  // властивість
        {
            get => power;

            set
            {
                if (value <= 0)  // валідація 
                    throw new ArgumentException("Power must be positive");
                power = value;
            }
        }
        public Engine() { }  // конструктор без параметрів

        public Engine(int power) // параматизований конструктор 
        {
            Power = power;
        }
        public override string ToString() // перевизначили тустрінг
        {
            return $"Power :: {Power} HP";
        }
    }
}
