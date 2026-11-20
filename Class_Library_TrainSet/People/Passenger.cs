using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library_TrainSet.People
{
    public class Passenger : Person
    {
        public int TicketNumber { get; set; }
        public bool HasTicket { get; set; }
        public int SeatNumber { get; set; }
        public Passenger() { }       
        public Passenger(
            string firstName,
            string lastName,
            int ticketNumber,
            bool hasTicket,
            int seatNumber)
            : base(firstName, lastName)
        {
            TicketNumber = ticketNumber;
            HasTicket = hasTicket;
            SeatNumber = seatNumber;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Ticket :: {TicketNumber}, Seat: {SeatNumber}";
        }
    }
}
