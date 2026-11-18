using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library_TrainSet.Intheface
{
    public interface IPassengerService
    {
        void CheckTickets(); // первіряємо квитки 
        void MakeTea(); // робимо чай
        void MakeCoffee(); // робимо кофе
    }
}
