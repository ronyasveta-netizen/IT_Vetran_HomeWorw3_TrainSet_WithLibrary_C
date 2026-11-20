using Class_Library_TrainSet.Intheface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library_TrainSet.People
{
    // клас наслідує від персони і повинен реалізувати всі методи інтерфейса
    public class Driver : Person, ILocomotiveControl
    {

        private int experienceYears = 0; // має своє поле 

        public int ExperienceYears  // prop з валідацією 
        {
            get => experienceYears;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Experience cannot be negative");

                experienceYears = value;
            }
        }
        public Driver() { } // конструктор за замовчуванням 

        //  параматизований конструктор на основі батьківського
        public Driver(
            string name,
            string surname,
            int experienceYears)
            : base(name, surname)
        {
            ExperienceYears = experienceYears;
        }

        public override string ToString() // перевизначений тустрінг
        {
            return $"{base.ToString()}, Experience :: {ExperienceYears} years";
        }

        public void Accelerate()  // методи з інтерфейсу з обовязковою реалізацією
        {
            Console.WriteLine("Let's speed up the pace");
        }

        public void Brake() // методи з інтерфейсу з обовязковою  реалізацією
        {
            Console.WriteLine("Reduce speed");
        }
    }
}
