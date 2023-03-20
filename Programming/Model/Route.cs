using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Route
    {
        private string _departurePoint;
        private string _destination;
        private int _flightTime;

        public string DeparturePoint
        {
            get { return _departurePoint; }
            set { _departurePoint = value; }
        }
        public string Destination
        {
            get { return _destination; }
            set { _destination = value;}
        }
        public int FlightTime
        {
            get { return _flightTime; } 
            set { _flightTime  = value * 60 ;}
        }
        public Route(string departurePoint, string destination, int flightTime)
        {
            DeparturePoint= departurePoint;
            Destination= destination;
            FlightTime= flightTime;
        }
        public Route() { }
    }
}
