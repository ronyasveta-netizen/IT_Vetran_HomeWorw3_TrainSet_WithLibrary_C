using Class_Library_TrainSet.Intheface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library_TrainSet.People
{
    public class Attendant : Person, IPassengerService
    {
        public bool IsMan { get; set; }
        public Attendant() { }
        public Attendant(
            string firstName,
            string lastName,
            bool isMan)
            : base(firstName, lastName)
        {
            IsMan = isMan;
        }

        public void CheckTickets()
        {
            Console.WriteLine("Check ticket");
        }

        public void MakeCoffee()
        {
            Console.WriteLine("Make black coffee");
        }

        public void MakeTea()
        {
            Console.WriteLine("Make green tea");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Gender :: {(IsMan ? "Man" : "Woman")}";
        }
    }
}
