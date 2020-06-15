using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_V5_Vasilets.Model
{
    public class Airport
    {
        private List<Flight> listOfFlights;
        private List<Plane> listOfPlanes;

        public List<Flight> ListOfFlights { get => listOfFlights; set => listOfFlights = value; }
        public List<Plane> ListOfPlanes { get => listOfPlanes; set => listOfPlanes = value; }

        public Airport()
        {

            this.listOfFlights = new List<Flight>();
            this.listOfPlanes = new List<Plane>();
        }
        public void AddFlight(Flight flight)
        {
            this.listOfFlights.Add(flight);
        }
        public void AddPlane(Plane plane)
        {
            this.listOfPlanes.Add(plane);
        }

        public Flight GetFlight(string Name)
        {
            Flight flight = new Flight();
            foreach(Flight F in listOfFlights )
            {
                if (F.Name == Name)
                {
                    flight = F;
                }
            }
            return flight;
        }
        public List<string> GetFlightNames()
        {
            List<string> FlightNames = new List<string>();

            foreach (Flight F in ListOfFlights)
            {
                FlightNames.Add(F.Name);
            }
            return FlightNames;
        }
        public void ChangeTime(string Name, TimeSpan DelayTime, DateTime LastBuyTime)
        {
            foreach (Flight F in ListOfFlights)
            {
                if (Name == F.Name)
                {
                    F.LastBuyTime = LastBuyTime;
                    F.DelayTime = DelayTime;
                }
            }

        }

    }
}
