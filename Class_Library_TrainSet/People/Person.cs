using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library_TrainSet.People
{
    // абстрактний клас людина  базовий клас для всіх людей в системі
    public abstract class Person
    {
        private string name = "NoName"; // значення за замовчуванням 
        private string surname = "NoSurname";

        protected Person() { } // конструктор без параметрвів

        public string Name // властивіст з валідацією вводу 
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty");

                name = value;
            }
        }

        public string Surname // властивіст з валідацією вводу
        {
            get => surname;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Surname cannot be empty");

                surname = value;
            }
        }

        protected Person(string name, string surname) // параматизований конструктор
        {
            Name = name;
            Surname = surname;
        }

        public override string ToString() // первизначили тустрінг
        {
            return $"{Name} {Surname}";
        }
    }
}
