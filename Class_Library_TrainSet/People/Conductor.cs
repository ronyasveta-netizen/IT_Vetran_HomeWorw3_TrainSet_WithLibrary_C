using Class_Library_TrainSet.Intheface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library_TrainSet.People
{
    public class Conductor : Person, IPassengerService
    {
        public bool IsMan { get; set; }
        public Conductor() { }
        public Conductor(
            string firstName,
            string lastName,
            bool isMan)
            : base(firstName, lastName)
        {
            IsMan = isMan;
        }

        public void CheckTickets()
        {
            throw new NotImplementedException();
        }

        public void MakeCoffee()
        {
            throw new NotImplementedException();
        }

        public void MakeTea()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Gender: {(IsMan ? "Man" : "Woman")}";
        }
    }
}
